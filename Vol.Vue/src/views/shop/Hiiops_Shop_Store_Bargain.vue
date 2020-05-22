<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Bargain.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Bargain.js";
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
                    cnName: '砍价商品',
                    name: 'Hiiops_Shop_Store_Bargain',
                    url: "/Hiiops_Shop_Store_Bargain/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'砍价商品Id',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Is_Hot',title:'是否推荐0不推荐1推荐',type:'byte',width:90,require:true,align:'left',sortable:true},
                       {field:'Is_Del',title:'是否删除 0未删除 1删除',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Postage',title:'是否包邮 0不包邮 1包邮',type:'byte',width:90,require:true,align:'left'},
                       {field:'Postage',title:'邮费',type:'decimal',width:90,align:'left'},
                       {field:'Rule',title:'砍价规则',type:'string',width:90,align:'left'},
                       {field:'Look',title:'砍价商品浏览量',type:'int',width:80,align:'left'},
                       {field:'Share',title:'砍价商品分享量',type:'int',width:80,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:80,require:true,align:'left'},
                       {field:'Temp_Id',title:'运费模板Id',type:'int',width:80,align:'left'},
                       {field:'Volume',title:'体积',type:'decimal',width:90,align:'left'},
                       {field:'Quota',title:'限购总数',type:'int',width:80,require:true,align:'left'},
                       {field:'Quota_Show',title:'限量总数显示',type:'int',width:80,require:true,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Weight',title:'重量',type:'decimal',width:90,align:'left'},
                       {field:'Cost',title:'成本价',type:'decimal',width:90,align:'left'},
                       {field:'Info',title:'砍价活动简介',type:'string',width:220,align:'left'},
                       {field:'Give_Integral',title:'反多少积分',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Product_Id',title:'关联商品Id',type:'int',width:80,require:true,align:'left'},
                       {field:'Title',title:'砍价活动名称',type:'string',width:220,require:true,align:'left'},
                       {field:'Image',title:'砍价活动图片',type:'string',width:220,require:true,align:'left'},
                       {field:'Unit_Name',title:'单位名称',type:'string',width:90,align:'left'},
                       {field:'Stock',title:'库存',type:'int',width:80,align:'left'},
                       {field:'Sales',title:'销量',type:'int',width:80,align:'left'},
                       {field:'Images',title:'砍价商品轮播图',type:'string',width:220,require:true,align:'left'},
                       {field:'Start_Time',title:'砍价开启时间',type:'int',width:80,require:true,align:'left'},
                       {field:'Stop_Time',title:'砍价结束时间',type:'int',width:80,require:true,align:'left'},
                       {field:'Store_Name',title:'砍价商品名称',type:'string',width:220,align:'left'},
                       {field:'Price',title:'砍价金额',type:'decimal',width:90,align:'left'},
                       {field:'Num',title:'每次购买的砍价商品数量',type:'int',width:80,align:'left'},
                       {field:'Bargain_Max_Price',title:'用户每次砍价的最大金额',type:'decimal',width:90,align:'left'},
                       {field:'Bargain_Min_Price',title:'用户每次砍价的最小金额',type:'decimal',width:90,align:'left'},
                       {field:'Bargain_Num',title:'用户每次砍价的次数',type:'int',width:80,require:true,align:'left'},
                       {field:'Status',title:'砍价状态 0(到砍价时间不自动开启)  1(到砍价时间自动开启时间)',type:'byte',width:90,require:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'Min_Price',title:'砍价商品最低价',type:'decimal',width:90,align:'left'}],
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
