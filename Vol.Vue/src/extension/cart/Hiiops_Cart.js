//author:jxx
//此处是对表单的方法，组件，权限操作按钮等进行任意扩展(方法扩展可参照SellOrder.js)
import AsyncLoading from "@/components/basic/AsyncLoading.vue";
let extension = {
  components: { //动态扩充组件或组件路径
    //表单header、content、footer对应位置扩充的组件
    gridHeader: '', //{ template: "<div>扩展组xx件</div>" },
    gridBody: '',
    gridFooter: '',
    //弹出框(修改、编辑、查看)header、content、footer对应位置扩充的组件
    modelHeader: '',
    modelBody: () => ({
      component: import("./component/Hiiops_CartDetail.vue"),
      loading: AsyncLoading
    }),
    modelFooter: ''
  },
  buttons: {
    view: [],
    box: [],
    detail: []
  }, //扩展的按钮
  methods: { //事件扩展
    onInit() {
      //this.$store.getters.data().editor = this;
      this.$store.getters.data().editor = this;

      //添加弹出框生成静态页面的按钮
      this.boxButtons.splice(0, 0, ...[{
          name: "编辑详情",
          icon: 'ios-resize',
          type: 'info',
          onClick: function () {
            this.$refs.modelBody.model = 1;
            console.log(this.$refs.modelBody)
          }
        }, {
          name: "生成静态页面",
          icon: 'ios-cart',
          type: 'info',
          onClick: function () {
            this.publish();
          }
        },
        {
          name: "预览页面",
          icon: 'ios-globe',
          type: 'info',
          onClick: function () {
            if (!this.currentRow ||
              !this.currentRow.DetailContent ||
              !this.currentRow.StaticUrl) {
              return this.$Message.error("请先【保存】,再点击【生成静态页面】")
            }
            this.preview(this.currentRow);
          }
        }
      ])
//动态修改table并给列添加事件
this.columns.forEach(x => {
  if (x.field == "DetailContent") {
      x.formatter = (row) => {
        return '<a href="' + this.http.ipAddress + row.StaticUrl + '" target="_blank" >查看</a>'
      }
      
  }
})
      

      //启用多图上传,其他上传参数，参照volupload组件api
      this.editFormOptions.forEach(x => {
        x.forEach(item => {
          if (item.field == 'CoverImage' || item.field == 'Images') {
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
    },
    modelOpenAfter(row) {}, //点击编辑/新建按钮弹出框后，可以在此处写逻辑，如，从后台获取数据
    addBefore(formData) { //新建前验证
      console.log(JSON.stringify(formData))
      return this.validContent(formData);
    },
    updateBefore(formData) { //修改前验证
      console.log(JSON.stringify(formData))
      return this.validContent(formData);
    },
    validContent(formData) {
      console.log(JSON.stringify(formData))
      if (!this.currentRow.DetailContent) {
        this.$Message.error("请编辑车辆详情");
        return false;
      }
      formData.mainData.DetailContent = this.currentRow.DetailContent; 
      return true;
    },
    preview(row) { //预览html页面
      if (!row.StaticUrl || row.StaticUrl.indexOf('.html') == -1 || !this.base.isUrl(this.http.ipAddress + row.StaticUrl)) {
        return this.$Message.error("请先发布静态页面")
      }
      window.open(this.http.ipAddress + row.StaticUrl);
    },
    publish() { //生成静态页面
      if (!this.currentRow || !this.currentRow[this.table.key]) {
        return this.$Message.error("请先保存数据")
      }
      if (!this.currentRow.DetailContent) {
        return this.$Message.error("请编辑要发布的内容")
      }
      this.http.post("api/Hiiops_Cart/createPage", this.currentRow).then(x => {
        if (x.status) {
          // this.editFormFileds.DetailUrl = x.data.url;
          this.currentRow.StaticUrl = x.data.url;
        }
        this.refresh();
        return this.$Message.info(x.message)
      })
    },
  }
};
export default extension;
