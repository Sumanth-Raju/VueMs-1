<template>
  <div class="hello">
  <div>{{Cust}}</div>
  </div>
</template>

<script>
import http from "../service/http-comman.js"
export default {
  name: 'HelloWorld',
  props: {
    msg: String
  },
  data(){
    return{
      Cust : ""
    }
  },
  methods:{
    getAll(){
      
      http.get("api/customer").then((response) => {
          console.log(response);
          this.Cust = response.data;
      });
      
    }
  },
  mounted(){

    this.getAll();
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
