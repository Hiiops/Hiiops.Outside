//author:jxx
//此处是对表单的方法，组件，权限操作按钮等进行任意扩展(方法扩展可参照SellOrder.js)
import AsyncLoading from "@/components/basic/AsyncLoading.vue";
let extension = {
    components: {//动态扩充组件或组件路径
        //表单header、content、footer对应位置扩充的组件
        gridHeader:'',//{ template: "<div>扩展组xx件</div>" },
        gridBody: '',
        gridFooter: '',
        //弹出框(修改、编辑、查看)header、content、footer对应位置扩充的组件
        modelHeader: '',
        modelBody:  () => ({ component: import("./component/Hiiops_CartDetail.vue"), loading: AsyncLoading }),
        modelFooter: ''
    },
    buttons: {view: [], box:[],  detail:[]},//扩展的按钮
    methods: {//事件扩展
       onInit() {
             //启用多图上传,其他上传参数，参照volupload组件api
      //this.$store.getters.data().editor = this;
      this.editFormOptions.forEach(x => {
        x.forEach(item => {
          if (item.field == 'CoverImage'||item.field == 'Images') {
           // item.type = 'file';
            //设置成100%宽度
            item.colSize = 12;
            item.multiple = true;  
            //最多可以上传3张照片
            item.maxFile = 6;
            //限制图片大小，默认3M
            item.maxSize = 5;
            item.append = true;
          }
        })
      })
       }
    }
};
export default extension;