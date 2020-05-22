<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Product_Reply.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Product_Reply.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Id',
                    footer: "Foots",
                    cnName: '商品评价',
                    name: 'Hiiops_Shop_Store_Product_Reply',
                    url: "/Hiiops_Shop_Store_Product_Reply/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'评论Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'UId',title:'用户Id',type:'int',width:90,require:true,align:'left',sortable:true},
                       {field:'OId',title:'订单Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Unique',title:'唯一Id',type:'string ',width:120,require:true,align:'left'},
                       {field:'Product_Id',title:'商品Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Reply_Type',title:'某种商品类型(普通商品、秒杀商品）',type:'string',width:120,require:true,align:'left'},
                       {field:'Product_Score',title:'商品分数',type:'byte',width:90,require:true,align:'left'},
                       {field:'Service_Score',title:'服务分数',type:'byte',width:90,require:true,align:'left'},
                       {field:'Comment',title:'评论内容',type:'string',width:220,require:true,align:'left'},
                       {field:'Pics',title:'评论图片',type:'string',width:90,require:true,align:'left'},
                       {field:'Merchant_Reply_Content',title:'管理员回复内容',type:'string',width:220,align:'left'},
                       {field:'Merchant_Reply_Time',title:'管理员回复时间',type:'int',width:90,align:'left'},
                       {field:'Is_Del',title:'0未删除1已删除',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Reply',title:'0未回复1已回复',type:'byte',width:90,require:true,align:'left'},
                       {field:'Nickname',title:'用户名称',type:'string',width:180,require:true,align:'left'},
                       {field:'Avatar',title:'用户头像',type:'string',width:220,require:true,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:90,align:'left',sortable:true}],
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
