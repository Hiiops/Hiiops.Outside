<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Coupon_Issue.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Coupon_Issue.js";
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
                    cnName: '优惠券列表',
                    name: 'Hiiops_Shop_Store_Coupon_Issue',
                    url: "/Hiiops_Shop_Store_Coupon_Issue/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'主键',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Is_Give_Subscribe',title:'是否首次关注赠送 0-否(默认) 1-是',type:'byte',width:90,require:true,align:'left'},
                       {field:'Full_Reduction',title:'消费满多少赠送优惠券',type:'decimal',width:90,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
                       {field:'Is_Full_Give',title:'是否满赠0-否(默认) 1-是',type:'byte',width:90,align:'left'},
                       {field:'Is_Permanent',title:'是否无限',type:'byte',width:90,align:'left'},
                       {field:'Remain_Count',title:'优惠券剩余领取数量',type:'byte',width:90,require:true,align:'left'},
                       {field:'Total_Count',title:'优惠券领取数量',type:'int',width:80,require:true,align:'left'},
                       {field:'End_Time',title:'优惠券领取结束时间',type:'datetime',width:150,require:true,align:'left',sortable:true},
                       {field:'Start_Time',title:'优惠券领取开始时间',type:'datetime',width:150,require:true,align:'left',sortable:true},
                       {field:'CId',title:'优惠券ID',type:'int',width:80,require:true,align:'left'},
                       {field:'Status',title:'1 正常 0 未开启 -1 已无效',type:'byte',width:90,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:150,align:'left',sortable:true}],
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
