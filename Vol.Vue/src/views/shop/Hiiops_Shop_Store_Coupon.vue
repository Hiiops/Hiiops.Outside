<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Coupon.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Coupon.js";
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
                    cnName: '优惠券模板',
                    name: 'Hiiops_Shop_Store_Coupon',
                    url: "/Hiiops_Shop_Store_Coupon/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'优惠券表Id',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Type',title:'优惠券类型 0-通用 1-品类券 2-商品券',type:'byte',width:90,require:true,align:'left'},
                       {field:'Category_Id',title:'分类Id',type:'int',width:80,require:true,align:'left'},
                       {field:'Product_Id',title:'所属商品Id',type:'string',width:180,require:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'Is_Del',title:'是否删除',type:'byte',width:90,require:true,align:'left'},
                       {field:'Status',title:'状态（0：关闭，1：开启）',type:'byte',width:90,require:true,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:80,require:true,align:'left'},
                       {field:'Coupon_Time',title:'优惠券有效期限（单位：天）',type:'int',width:80,require:true,align:'left'},
                       {field:'Use_Min_Price',title:'最低消费多少金额可用优惠券',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Coupon_Price',title:'兑换的优惠券面值',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Integral',title:'兑换消耗积分值',type:'int',width:80,require:true,align:'left'},
                       {field:'Title',title:'优惠券名称',type:'string',width:180,require:true,align:'left'},
                       {field:'Add_Time',title:'兑换项目添加时间',type:'int',width:80,require:true,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:150,align:'left',sortable:true}],
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
