<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Article.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Article.js";
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
                    cnName: '文章管理',
                    name: 'Hiiops_Shop_Article',
                    url: "/Hiiops_Shop_Article/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'文章管理Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CId',title:'分类Id',type:'string',width:220,align:'left',sortable:true},
                       {field:'Title',title:'文章标题',type:'string',width:220,require:true,align:'left'},
                       {field:'Author',title:'文章作者',type:'string',width:220,align:'left'},
                       {field:'Image_Input',title:'文章图片',type:'string',width:220,require:true,align:'left'},
                       {field:'Synopsis',title:'文章简介',type:'string',width:220,align:'left'},
                       {field:'Share_Title',title:'文章分享标题',type:'string',width:220,align:'left'},
                       {field:'Share_Synopsis',title:'文章分享简介',type:'string',width:220,align:'left'},
                       {field:'Visit',title:'浏览次数',type:'string',width:220,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:90,require:true,align:'left'},
                       {field:'Url',title:'原文链接',type:'string',width:220,align:'left'},
                       {field:'Status',title:'状态',type:'byte',width:90,require:true,align:'left'},
                       {field:'HIde',title:'是否隐藏',type:'byte',width:90,require:true,align:'left'},
                       {field:'Admin_Id',title:'管理员Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Mer_Id',title:'商户Id',type:'int',width:90,align:'left'},
                       {field:'Product_Id',title:'商品关联Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Is_Hot',title:'是否热门(小程序)',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_banner',title:'是否轮播图(小程序)',type:'byte',width:90,require:true,align:'left'},
                       {field:'CreateId',title:'CreateId',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyId',title:'ModifyId',type:'int',width:90,hidden:true,align:'left'},
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
