import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../modules/home/Home.vue'
import About from '../modules/about/About.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
  },
  {
    path: '/',
    name: 'About',
    component: About,
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
})

export default router
