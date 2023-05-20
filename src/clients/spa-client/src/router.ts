import { createRouter, createWebHistory } from 'vue-router'
import HomePage from '@/pages/home-page'
import LoginPage from '@/pages/login-page'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path:"/",
      component: HomePage
    },
    {
      path:"/login",
      component: LoginPage
    }
  ]
})

export default router
