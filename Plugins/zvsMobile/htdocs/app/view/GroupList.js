Ext.require(['Ext.Panel', 'zvsMobile.store.Groups'], function () {
  
    Ext.define('zvsMobile.view.GroupList', {
        extend: 'Ext.Panel',
        xtype: 'GroupList',

        constructor: function (config) {
            var self = this;
            Ext.apply(config || {}, {
                items: [{
                    xtype: 'toolbar',
                    docked: 'top',
                    title: 'Groups',
                    items: [{
                        xtype: 'button',
                        iconMask: true,
                        iconCls: 'refresh',
                        handler: function () {
                            GroupsStore.load();
                        }
                    }]
                }, {
                    xtype: 'list',
                    itemTpl: new Ext.XTemplate(
						    '<div class="group">',
						        '<div class="imageholder"></div>',
						        '<h1>{name} ({count})</h1>',
						    '</div>'
					    ),
                    cls: 'GroupList',
                    store: GroupsStore,
                    listeners: {
                        scope: this,
                        selectionchange: function (list, records) {
                            if (records[0] !== undefined) {
                                var ViewPort = self.parent;
                                var GroupDetails = ViewPort.items.items[1];
                                var groupId = records[0].data.id;
                                GroupDetails.loadScene(groupId);
                                ViewPort.getLayout().setAnimation({ type: 'slide', direction: 'left' });
                                ViewPort.setActiveItem(GroupDetails);
                            }
                        }
                    }
                }],
                listeners: {
                    scope: this,
                    activate: function () {
                        self.items.items[1].deselectAll();
                    }
                }
            });
            this.callOverridden([config]);
        },
        config:
	{
	    layout: 'fit'
	}
    });
});



					