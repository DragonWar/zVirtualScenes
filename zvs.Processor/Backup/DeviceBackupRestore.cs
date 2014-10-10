﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using zvs.Entities;
using System.Data.Entity;

namespace zvs.Processor.Backup
{
    public class DeviceBackupRestore : BackupRestore
    {
        public class DeviceBackup
        {
            public string Name { get; set; }
            public int NodeNumber { get; set; }
        }

        public override string Name
        {
            get { return "Device Names"; }
        }

        public override string FileName
        {
            get { return "DevicesBackup.zvs"; }
        }

        public async override Task<ExportResult> ExportAsync(string fileName)
        {
            using (var context = new zvsContext())
            {
                var backupDevices = await context.Devices
                    .OrderBy(o => o.Name)
                    .Select(o => new DeviceBackup()
                    {
                        NodeNumber = o.NodeNumber,
                        Name = o.Name
                    })
                    .ToListAsync();

                var saveResult = await SaveAsXMLToDiskAsync(backupDevices, fileName);

                if (saveResult.HasError)
                    return new ExportResult(saveResult.Message, saveResult.HasError);

                return new ExportResult(string.Format("Exported {0} device names to {1}", backupDevices.Count, Path.GetFileName(fileName)), false);
            }
        }

        public async override Task<RestoreSettingsResult> ImportAsync(string fileName)
        {
            var result = await ReadAsXMLFromDiskAsync<List<DeviceBackup>>(fileName);

            if (result.HasError)
                return new RestoreSettingsResult(result.Message);

            var backupDevices = result.Data;
            var ImportedCount = 0;

            using (var context = new zvsContext())
            {
                foreach (var d in await context.Devices.ToListAsync())
                {
                    var dev = backupDevices.FirstOrDefault(o => o.NodeNumber == d.NodeNumber);
                    if (dev != null)
                    {
                        d.Name = dev.Name;
                        ImportedCount++;
                    }
                }

                var saveResult = await context.TrySaveChangesAsync();

                if (saveResult.HasError)
                    return new RestoreSettingsResult(saveResult.Message);
            }

            return new RestoreSettingsResult(string.Format("Restored {0} device names. File: '{1}'", ImportedCount, Path.GetFileName(fileName)), fileName);
        }

        
    }
}
