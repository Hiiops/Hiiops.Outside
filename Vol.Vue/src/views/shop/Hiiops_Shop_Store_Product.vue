<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Product.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Product.js";
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
                    cnName: '商品管理',
                    name: 'Hiiops_Shop_Store_Product',
                    url: "/Hiiops_Shop_Store_Product/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'商品Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Mer_Id',title:'商户Id(0为总后台管理员创建,不为0的时候是商户后台创建)',type:'int',width:90,require:true,align:'left',sortable:true},
                       {field:'Image',title:'商品图片',type:'string',width:220,require:true,align:'left'},
                       {field:'SlIder_Image',title:'轮播图',type:'string',width:220,require:true,align:'left'},
                       {field:'Store_Name',title:'商品名称',type:'string',width:220,require:true,align:'left'},
                       {field:'Store_Info',title:'商品简介',type:'string',width:220,require:true,align:'left'},
                       {field:'Keyword',title:'关键字',type:'string',width:220,require:true,align:'left'},
                       {field:'Bar_Code',title:'商品条码（一维码）',type:'string',width:90,require:true,align:'left'},
                       {field:'Cate_Id',title:'分类Id',type:'string',width:180,require:true,align:'left'},
                       {field:'Price',title:'商品价格',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Vip_Price',title:'会员价格',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Ot_Price',title:'市场价',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Postage',title:'邮费',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Unit_Name',title:'单位名',type:'string',width:120,require:true,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:90,require:true,align:'left'},
                       {field:'Sales',title:'销量',type:'int',width:90,require:true,align:'left'},
                       {field:'Stock',title:'库存',type:'int',width:90,require:true,align:'left'},
                       {field:'Is_Show',title:'状态（0：未上架，1：上架）',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Hot',title:'是否热卖',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_benefit',title:'是否优惠',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_best',title:'是否精品',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_New',title:'是否新品',type:'byte',width:90,require:true,align:'left'},
                       {field:'Add_Time',title:'添加时间',type:'int',width:90,require:true,align:'left'},
                       {field:'Is_Postage',title:'是否包邮',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Del',title:'是否删除',type:'byte',width:90,require:true,align:'left'},
                       {field:'Mer_Use',title:'商户是否代理 0不可代理1可代理',type:'byte',width:90,require:true,align:'left'},
                       {field:'Give_Integral',title:'获得积分',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Cost',title:'成本价',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Is_Seckill',title:'秒杀状态 0 未开启 1已开启',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_bargain',title:'砍价状态 0未开启 1开启',type:'byte',width:90,align:'left'},
                       {field:'Is_Good',title:'是否优品推荐',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Sub',title:'是否单独分佣',type:'byte',width:90,require:true,align:'left'},
                       {field:'Ficti',title:'虚拟销量',type:'int',width:90,align:'left'},
                       {field:'Browse',title:'浏览量',type:'int',width:90,align:'left'},
                       {field:'Code_Path',title:'商品二维码地址(用户小程序海报)',type:'string',width:180,require:true,align:'left'},
                       {field:'Soure_Link',title:'淘宝京东1688类型',type:'string',width:220,align:'left'},
                       {field:'VIdeo_Link',title:'主图视频链接',type:'string',width:220,require:true,align:'left'},
                       {field:'Temp_Id',title:'运费模板Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Spec_Type',title:'规格 0单 1多',type:'byte',width:90,require:true,align:'left'},
                       {field:'Activity',title:'活动显示排序1=秒杀，2=砍价，3=拼团',type:'string',width:220,require:true,align:'left'},
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
