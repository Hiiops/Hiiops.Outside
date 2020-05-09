<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/cart/Hiiops_Cart_Coupon.js此处编写
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
    import extend from "@/extension/cart/Hiiops_Cart_Coupon.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Coupon_Id',
                    footer: "Foots",
                    cnName: '优惠券',
                    name: 'Hiiops_Cart_Coupon',
                    url: "/Hiiops_Cart_Coupon/",
                    sortName: "Coupon_Id"
                },
                extend: extend,
                editFormFileds: {"Expire":"","StartTime":"","ExpireTime":"","CouponType":"","Status":"","Denomination":"","Name":"","Privilege":"","Remark":"","Images":""},
                editFormOptions: [[{"dataKey":"ExpireStatus","title":"过期状态","required":true,"field":"Expire","type":"select"},
                               {"title":"开始时间","field":"StartTime","type":"datetime"},
                               {"title":"结束时间","field":"ExpireTime","type":"datetime"}],
                              [{"dataKey":"CouponType","title":"优惠券类型","required":true,"field":"CouponType","type":"select"},
                               {"dataKey":"enable","title":"状态","field":"Status","type":"select"},
                               {"title":"面值","required":true,"field":"Denomination"}],
                              [{"title":"优惠券名 ","field":"Name"},
                               {"title":"特权","field":"Privilege"},
                               {"title":"备注","field":"Remark"}],
                              [{"title":"图片","field":"Images","type":"img"}]],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Images',title:'图片',type:'img',width:90,align:'left',sortable:true},
                       {field:'Name',title:'优惠券名 ',type:'string',width:90,align:'left'},
                       {field:'Coupon_Id',title:'主键',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Expire',title:'过期状态',type:'int',bind:{ key:'ExpireStatus',data:[]},width:80,require:true,align:'left'},
                       {field:'StartTime',title:'开始时间',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'ExpireTime',title:'结束时间',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'CouponType',title:'优惠券类型',type:'int',bind:{ key:'CouponType',data:[]},width:80,require:true,align:'left'},
                       {field:'Status',title:'状态',type:'int',bind:{ key:'enable',data:[]},width:80,align:'left'},
                       {field:'Denomination',title:'面值',type:'string',width:90,require:true,align:'left'},
                       {field:'Privilege',title:'特权',type:'string',width:90,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
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
