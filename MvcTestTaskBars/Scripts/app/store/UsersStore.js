Ext.define('MvcExtTest.store.UsersStore', {
    extend: 'Ext.data.Store',
    model: 'MvcExtTest.model.User',
    autoLoad: true,
    storeId: 'UsersStore',
    proxy: {
        type: 'ajax',
        url: 'Scripts/app/data/users.json',
        reader: {
            type: 'json',
            root: 'users',
            successProperty: 'success'
        }
    }
});