<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/cart/Hiiops_Cart_SellerUser.js此处编写
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
    import extend from "@/extension/cart/Hiiops_Cart_SellerUser.js";
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
                    cnName: '会员',
                    name: 'Hiiops_Cart_SellerUser',
                    url: "/Hiiops_Cart_SellerUser/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {"Name":"","SearchKey":"","Phone":"","NickName":"","Sex":"","Province":"","Country":"","Remark":""},
                searchFormOptions: [[{"title":"姓名","field":"Name"},{"title":"搜索记录","field":"SearchKey"},{"title":"电话","field":"Phone"}],[{"title":"昵称","field":"NickName"},{"title":"性别","field":"Sex","type":"number"}],[{"title":"省份","field":"Province"},{"title":"国家","field":"Country"},{"title":"备注","field":"Remark"}]],
                columns: [{field:'Id',title:'主键',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Name',title:'姓名',type:'string',width:220,require:true,align:'left',sortable:true},
                       {field:'HeadImgUrl',title:'头像',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'SearchKey',title:'搜索记录',type:'string',width:90,align:'left'},
                       {field:'Status',title:'状态',type:'int',width:90,require:true,align:'left'},
                       {field:'Phone',title:'电话',type:'string',width:90,align:'left'},
                       {field:'OpenId',title:'微信OPENID',type:'string',width:90,align:'left'},
                       {field:'NickName',title:'昵称',type:'string',width:90,align:'left'},
                       {field:'Sex',title:'性别',type:'int',width:90,align:'left'},
                       {field:'Province',title:'省份',type:'string',width:90,align:'left'},
                       {field:'Country',title:'国家',type:'string',width:90,align:'left'},
                       {field:'Privilege',title:'特权',type:'string',width:90,align:'left'},
                       {field:'UnionId',title:'UNIONID',type:'string',width:90,align:'left'},
                       {field:'LastLoginTime',title:'最后登录时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'LoginIp',title:'登录IP',type:'string',width:90,align:'left'},
                       {field:'Token',title:'TOKEN',type:'string',width:90,align:'left'},
                       {field:'Password',title:'密码',type:'string',width:90,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'创建人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'创建人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Account',title:'账户',type:'string',width:220,align:'left'}],
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
