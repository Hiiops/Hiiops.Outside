<template>
  <div class="c-container">
    <div class="item">
      <div style="height:300px;" class="left">
        <VolHeader icon="md-apps" text="浏览统计" style="margin-bottom: 5px;"></VolHeader>
        <div style="height:258px;" :id="bar"></div>
      </div>
      <div style="height:300px;" class="right">
        <VolHeader icon="md-apps" text="快速查询" style="margin-bottom: 20px;"></VolHeader>
        <VolForm style="padding-right: 35px;"
                 ref="myform1"
                 :loadKey="true"
                 :formFileds="formFileds1"
                 :formRules="formRules1"></VolForm>
      </div>
    </div>

    <div class="item">
      <div style="height:290px;" class="left">
        <VolHeader icon="md-apps" text="数据汇总" style="margin-bottom: 20px;"></VolHeader>
        <VolForm style="padding-left: 35px;"
                 ref="myform1"
                 :loadKey="true"
                 :formFileds="formFileds2"
                 :formRules="formRules2"></VolForm>
      </div>
      <div style="height:290px;" class="right">
        <VolHeader icon="md-apps" text="用户分布" style="margin-bottom: 5px;"></VolHeader>
        <div style="height:258px;" :id="pie"></div>
      </div>
    </div>
  </div>
</template>
<script>
  import VolHeader from "@/components/basic/VolHeader.vue";
  import VolForm from "@/components/basic/VolForm.vue";
  let echarts = require("echarts");
  import options from "./charts/chartOptions";
  import {
    formFileds1,
    formRules1,
    formFileds2,
    formRules2
  } from "./charts/formOptions";
  export default {
    components: { VolForm, VolHeader },
    data() {
      return {
        formFileds1: formFileds1,
        formRules1: formRules1,
        formFileds2: formFileds2,
        formRules2: formRules2,
        bar: "b-" + ~~(Math.random(10000, 100000) * 100000),
        pie: "p-" + ~~(Math.random(10000, 100000) * 100000),
        options: options
      };
    },
    mounted() {
      this.options.bar.title = {
        subtext: "商城运营数据",
        x: "center"
      };
      let $bar = echarts.init(document.getElementById(this.bar));
      $bar.setOption(this.options.bar);

      this.options.pie.legend.top = 50;
      this.options.pie.legend.right = 80;
      this.options.pie.legend.orient = "vertical";
      let $pie = echarts.init(document.getElementById(this.pie));
      $pie.setOption(this.options.pie);
    }
  };
</script>
<style lang="less" scoped>
  .c-container {
    background: #f1f1f1;
    padding: 10px;
    .item

  {
    display: flex;
    > div

  {
    flex: 1;
    margin: 10px;
    background: #fff;
  }

  }
  }
</style>
