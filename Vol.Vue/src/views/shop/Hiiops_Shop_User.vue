<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_User.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_User.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'UId',
                    footer: "Foots",
                    cnName: '管理会员',
                    name: 'Hiiops_Shop_User',
                    url: "/Hiiops_Shop_User/",
                    sortName: "UId"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'UId',title:'用户Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Account',title:'用户账号',type:'string',width:120,require:true,align:'left',sortable:true},
                       {field:'Pwd',title:'用户密码',type:'string',width:120,require:true,align:'left'},
                       {field:'Real_Name',title:'真实姓名',type:'string',width:90,require:true,align:'left'},
                       {field:'Birthday',title:'生日',type:'int',width:90,require:true,align:'left'},
                       {field:'Card_Id',title:'身份证号码',type:'string',width:90,require:true,align:'left'},
                       {field:'Mark',title:'用户备注',type:'string',width:220,require:true,align:'left'},
                       {field:'Partner_Id',title:'合伙人Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Group_Id',title:'用户分组Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Nickname',title:'用户昵称',type:'string',width:180,require:true,align:'left'},
                       {field:'Avatar',title:'用户头像',type:'string',width:220,require:true,align:'left'},
                       {field:'Phone',title:'手机号码',type:'string ',width:90,align:'left'},
                       {field:'Add_Time',title:'添加时间',type:'int',width:90,require:true,align:'left'},
                       {field:'Add_Ip',title:'添加ip',type:'string',width:90,require:true,align:'left'},
                       {field:'Last_Time',title:'最后一次登录时间',type:'int',width:90,require:true,align:'left'},
                       {field:'Last_Ip',title:'最后一次登录ip',type:'string',width:90,require:true,align:'left'},
                       {field:'Now_Money',title:'用户余额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Brokerage_Price',title:'佣金金额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Integral',title:'用户剩余积分',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Sign_Num',title:'连续签到天数',type:'int',width:90,require:true,align:'left'},
                       {field:'Status',title:'1为正常，0为禁止',type:'byte',width:90,require:true,align:'left'},
                       {field:'Level',title:'等级',type:'byte',width:90,require:true,align:'left'},
                       {field:'Spread_UId',title:'推广元Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Spread_Time',title:'推广员关联时间',type:'int',width:90,require:true,align:'left'},
                       {field:'User_Type',title:'用户类型',type:'string',width:120,require:true,align:'left'},
                       {field:'Is_Promoter',title:'是否为推广员',type:'byte',width:90,require:true,align:'left'},
                       {field:'Pay_Count',title:'用户购买次数',type:'int',width:90,align:'left'},
                       {field:'Spread_Count',title:'下级人数',type:'int',width:90,align:'left'},
                       {field:'Clean_Time',title:'清理会员时间',type:'int',width:90,align:'left'},
                       {field:'Addres',title:'详细地址',type:'string',width:220,require:true,align:'left'},
                       {field:'AdminId',title:'管理员编号 ',type:'int',width:90,align:'left'},
                       {field:'Login_Type',title:'用户登陆类型，h5,wechat,routine',type:'string',width:120,require:true,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'UnionId',title:'只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段',type:'string',width:90,align:'left'},
                       {field:'OpenId',title:'用户的标识，对当前公众号唯一',type:'string',width:90,align:'left'},
                       {field:'Routine_OpenId',title:'小程序唯一身份Id',type:'string',width:120,align:'left'},
                       {field:'GroupId',title:'分组Id',type:'int',width:90,align:'left'},
                       {field:'TagId_List',title:'用户标签Id列表',type:'string',width:220,align:'left'},
                       {field:'Subscribe',title:'用户是否订阅该公众号标识',type:'byte',width:90,align:'left'},
                       {field:'Subscribe_Time',title:'关注公众号时间',type:'int',width:90,align:'left'},
                       {field:'Stair',title:'一级推荐人',type:'int',width:90,align:'left'},
                       {field:'Second',title:'二级推荐人',type:'int',width:90,align:'left'},
                       {field:'Order_Stair',title:'一级推荐人订单',type:'int',width:90,align:'left'},
                       {field:'Order_Second',title:'二级推荐人订单',type:'int',width:90,align:'left'},
                       {field:'Session_Key',title:'小程序用户会话密匙',type:'string',width:120,align:'left'},
                       {field:'Headimgurl',title:'头像',type:'string',width:220,require:true,align:'left'},
                       {field:'Sex',title:'性别',type:'byte',width:90,require:true,align:'left'},
                       {field:'City',title:'城市',type:'string',width:180,require:true,align:'left'},
                       {field:'Language',title:'语言',type:'string',width:180,require:true,align:'left'},
                       {field:'Province',title:'省份',type:'string',width:180,require:true,align:'left'},
                       {field:'Country',title:'国家',type:'string',width:180,require:true,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'}],
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
