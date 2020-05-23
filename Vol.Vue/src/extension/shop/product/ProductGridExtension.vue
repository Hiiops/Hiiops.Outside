<template>
  <div>
    <el-row class="topMenu">
      <el-button type="primary" plain :loading="false" >上架商品</el-button>
      <el-button type="success" plain>下架商品</el-button> 
      <el-button type="warning" plain>售馨商品</el-button>
      <el-button type="info" plain>停售商品</el-button>  
    </el-row>
    
  </div>
</template>
<script>
export default {
    components:{},
    data:{
        loading:false,
        type:1,//1上架商品2下架商品3售馨商品4停售商品
    },
    methods:{
        refreshProduct(){}
    }
}
</script>
<style lang="less" scoped>
.topMenu {
  padding: 15px; 
}
</style>>

 