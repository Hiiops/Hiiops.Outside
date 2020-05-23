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
    import ViewGrid from "@/components/basic/ViewGridProduct.vue";
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
                editFormFileds: {"Image":"","SlIder_Image":"","Store_Name":"","Store_Info":"","Keyword":"","Cate_Id":"","Price":"","Vip_Price":"","Bar_Code":"","Ot_Price":"","Postage":"","Unit_Name":"","Sort":"","Sales":"","Stock":"","Is_Show":"","Is_Hot":"","Is_benefit":"","Is_best":"","Is_New":"","Is_Postage":"","Mer_Use":"","Give_Integral":"","Cost":"","Is_Seckill":"","Is_bargain":"","Is_Good":"","Is_Sub":"","Ficti":"","Browse":"","Code_Path":"","Soure_Link":"","VIdeo_Link":"","Temp_Id":"","Spec_Type":"","Activity":""},
                editFormOptions: [[{"title":"商品图片","required":true,"field":"Image","type":"img"}],
                              [{"title":"轮播图","required":true,"field":"SlIder_Image","type":"img"}],
                              [{"title":"商品名称","required":true,"field":"Store_Name","type":"text"},
                               {"title":"商品简介","required":true,"field":"Store_Info","type":"textarea"}],
                              [{"title":"关键字","required":true,"field":"Keyword","type":"text"},
                               {"dataKey":"shop_category","title":"分类Id","required":true,"field":"Cate_Id","type":"select"},
                               {"title":"商品价格","required":true,"field":"Price","type":"decimal"},
                               {"title":"会员价格","required":true,"field":"Vip_Price","type":"decimal"}],
                              [{"title":"商品条码（一维码）","required":true,"field":"Bar_Code","type":"img"},
                               {"title":"市场价","required":true,"field":"Ot_Price","type":"decimal"}],
                              [{"title":"邮费","required":true,"field":"Postage","type":"decimal"},
                               {"title":"单位名","required":true,"field":"Unit_Name"},
                               {"title":"排序","required":true,"field":"Sort","type":"number"},
                               {"title":"销量","required":true,"field":"Sales","type":"number"}],
                              [{"dataKey":"sj_status","title":"库存","required":true,"field":"Stock","type":"select"},
                               {"dataKey":"enable","title":"状态","required":true,"field":"Is_Show","type":"select"},
                               {"dataKey":"enable","title":"是否热卖","required":true,"field":"Is_Hot","type":"select"},
                               {"dataKey":"enable","title":"是否优惠","required":true,"field":"Is_benefit","type":"select"}],
                              [{"dataKey":"enable","title":"是否精品","required":true,"field":"Is_best","type":"select"},
                               {"dataKey":"enable","title":"是否新品","required":true,"field":"Is_New","type":"select"},
                               {"dataKey":"status","title":"是否包邮","required":true,"field":"Is_Postage","type":"select"},
                               {"dataKey":"enable","title":"商户是否代理","required":true,"field":"Mer_Use","type":"select"}],
                              [{"title":"获得积分","required":true,"field":"Give_Integral","type":"decimal"},
                               {"title":"成本价","required":true,"field":"Cost","type":"decimal"},
                               {"dataKey":"enable","title":"秒杀状态","required":true,"field":"Is_Seckill","type":"select"},
                               {"dataKey":"enable","title":"砍价状态","field":"Is_bargain","type":"select"}],
                              [{"dataKey":"enable","title":"是否优品推荐","required":true,"field":"Is_Good","type":"select"},
                               {"dataKey":"enable","title":"是否单独分佣","required":true,"field":"Is_Sub","type":"select"},
                               {"title":"虚拟销量","field":"Ficti","type":"number"},
                               {"title":"浏览量","field":"Browse","type":"number"}],
                              [{"title":"商品二维码地址(用户小程序海报)","required":true,"field":"Code_Path","type":"img"}],
                              [{"title":"淘宝京东1688类型","field":"Soure_Link"},
                               {"title":"主图视频链接","required":true,"field":"VIdeo_Link"},
                               {"title":"运费模板Id","required":true,"field":"Temp_Id","type":"number"},
                               {"dataKey":"shop_guige","title":"规格","required":true,"field":"Spec_Type","type":"select"}],
                              [{"dataKey":"sort_actity","title":"活动显示排序","required":true,"field":"Activity","type":"select"}]],
                searchFormFileds: {"Id":"","Mer_Id":"","Store_Name":"","Store_Info":"","Keyword":"","Cate_Id":"","Is_Show":"","Is_Hot":"","Is_benefit":"","Is_best":"","Is_New":"","Add_Time":"","Is_Postage":"","Is_Good":""},
                searchFormOptions: [[{"title":"商品Id","field":"Id","type":"like"},{"title":"商户Id","field":"Mer_Id","type":"like"},{"title":"商品名称","field":"Store_Name","type":"like"},{"title":"商品简介","field":"Store_Info","type":"like"}],[{"title":"关键字","field":"Keyword","type":"like"},{"dataKey":"shop_category","title":"分类Id","field":"Cate_Id","type":"select"},{"dataKey":"enable","title":"状态","field":"Is_Show","type":"number"},{"dataKey":"enable","title":"是否热卖","field":"Is_Hot","type":"number"}],[{"dataKey":"enable","title":"是否优惠","field":"Is_benefit","type":"number"},{"dataKey":"enable","title":"是否精品","field":"Is_best","type":"number"},{"dataKey":"enable","title":"是否新品","field":"Is_New","type":"number"},{"dataKey":"enable","title":"添加时间","field":"Add_Time","type":"datetime"}],[{"dataKey":"status","title":"是否包邮","field":"Is_Postage","type":"number"},{"dataKey":"enable","title":"是否优品推荐","field":"Is_Good","type":"number"}]],
                columns: [{field:'Id',title:'商品Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Mer_Id',title:'商户Id',type:'int',width:90,require:true,align:'left',sortable:true},
                       {field:'Image',title:'商品图片',type:'img',width:220,require:true,align:'left'},
                       {field:'SlIder_Image',title:'轮播图',type:'img',width:220,require:true,align:'left'},
                       {field:'Store_Name',title:'商品名称',type:'string',width:220,require:true,align:'left'},
                       {field:'Store_Info',title:'商品简介',type:'string',width:220,require:true,align:'left'},
                       {field:'Keyword',title:'关键字',type:'string',width:220,require:true,align:'left'},
                       {field:'Bar_Code',title:'商品条码（一维码）',type:'img',width:90,require:true,align:'left'},
                       {field:'Cate_Id',title:'分类Id',type:'string',bind:{ key:'shop_category',data:[]},width:180,require:true,align:'left'},
                       {field:'Price',title:'商品价格',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Vip_Price',title:'会员价格',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Ot_Price',title:'市场价',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Postage',title:'邮费',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Unit_Name',title:'单位名',type:'string',width:120,require:true,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:90,require:true,align:'left'},
                       {field:'Sales',title:'销量',type:'int',width:90,require:true,align:'left'},
                       {field:'Stock',title:'库存',type:'int',bind:{ key:'sj_status',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_Show',title:'状态',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_Hot',title:'是否热卖',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_benefit',title:'是否优惠',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_best',title:'是否精品',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_New',title:'是否新品',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Add_Time',title:'添加时间',type:'int',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_Postage',title:'是否包邮',type:'byte',bind:{ key:'status',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_Del',title:'是否删除',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Mer_Use',title:'商户是否代理',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Give_Integral',title:'获得积分',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Cost',title:'成本价',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Is_Seckill',title:'秒杀状态',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_bargain',title:'砍价状态',type:'byte',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'Is_Good',title:'是否优品推荐',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Is_Sub',title:'是否单独分佣',type:'byte',bind:{ key:'enable',data:[]},width:90,require:true,align:'left'},
                       {field:'Ficti',title:'虚拟销量',type:'int',width:90,align:'left'},
                       {field:'Browse',title:'浏览量',type:'int',width:90,align:'left'},
                       {field:'Code_Path',title:'商品二维码地址(用户小程序海报)',type:'img',width:180,require:true,align:'left'},
                       {field:'Soure_Link',title:'淘宝京东1688类型',type:'string',width:220,align:'left'},
                       {field:'VIdeo_Link',title:'主图视频链接',type:'string',width:220,require:true,align:'left'},
                       {field:'Temp_Id',title:'运费模板Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Spec_Type',title:'规格',type:'byte',bind:{ key:'shop_guige',data:[]},width:90,require:true,align:'left'},
                       {field:'Activity',title:'活动显示排序',type:'string',bind:{ key:'sort_actity',data:[]},width:220,require:true,align:'left'},
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
