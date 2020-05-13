<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/cart/Hiiops_Cart_Banner.js此处编写
 -->
<template>
    <div>
        <view-grid :columns="columns"
                   :detail="detail"
                   :editFormFileds="editFormFileds"
                   :editFormOptions="editFormOptions"
                   :searchFormFileds="searchFormFileds"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/cart/Hiiops_Cart_Banner.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Banner_Id',
                    footer: "Foots",
                    cnName: '小程序',
                    name: 'Hiiops_Cart_Banner',
                    url: "/Hiiops_Cart_Banner/",
                    sortName: "CreateDate"
                },
                extend: extend,
                editFormFileds: {"Name":"","BannerType":"","Status":"","Advertising":"","AppletUrls":"","WebUrls":"","Privilege":"","Remark":"","Images":""},
                editFormOptions: [[{"title":"标题","field":"Name"},
                               {"dataKey":"BANNER","title":"类型","field":"BannerType","type":"select"},
                               {"dataKey":"status","title":"状态","required":true,"field":"Status","type":"select"}],
                              [{"title":"广告语","field":"Advertising"},
                               {"title":"小程序跳转","field":"AppletUrls"},
                               {"title":"普通地址","field":"WebUrls"}],
                              [{"title":"特权","field":"Privilege"},
                               {"title":"备注","field":"Remark"}],
                              [{"title":"图片","field":"Images","type":"img"}]],
                searchFormFileds: {"Name":"","BannerType":"","Remark":""},
                searchFormOptions: [[{"dataKey":"BANNER","title":"类型","field":"BannerType","type":"select"},{"title":"标题","field":"Name","type":"like"}],[{"title":"备注","field":"Remark","type":"like"}]],
                columns: [{field:'Banner_Id',title:'主键',type:'int',width:80,readonly:true,require:true,align:'left',sortable:true},
                       {field:'Name',title:'标题',type:'string',link:true,width:90,align:'left'},
                       {field:'BannerType',title:'类型',type:'string',bind:{ key:'BANNER',data:[]},width:90,align:'left'},
                       {field:'Status',title:'状态',type:'int',bind:{ key:'status',data:[]},width:80,require:true,align:'left'},
                       {field:'Advertising',title:'广告语',type:'string',width:90,align:'left'},
                       {field:'AppletUrls',title:'小程序跳转',type:'string',width:220,align:'left'},
                       {field:'WebUrls',title:'普通地址',type:'string',width:220,align:'left'},
                       {field:'Privilege',title:'特权',type:'string',width:220,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'Creator',title:'添加人',type:'string',width:130,align:'left'},
                       {field:'Images',title:'图片',type:'img',width:90,align:'left'}],
                detail: {
                    cnName:"#detailCnName",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
