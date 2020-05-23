<template>
  <div class="product-step">
    <el-steps :active="active">
      <el-step title="商品信息" icon="el-icon-edit"></el-step>
      <el-step title="商品详情" icon="el-icon-upload"></el-step>
      <el-step title="商品属性" icon="el-icon-setting"></el-step>
    </el-steps> 
    <el-button style="margin-top: 12px;" @click="next">下一步</el-button>
  </div>
</template>
<script>
export default {
  data() {
    return {
      active: 1
    };
  },

  methods: {
    next() {
      if (this.active++ > 2) this.active = 1;
    }
  }
};
</script>
<style lang="less" scoped>
.product-step {  
  padding: ;
}
</style>