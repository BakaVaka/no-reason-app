import { createRouter, createWebHashHistory } from 'vue-router'
import { LoginForm } from '@/features/login'

const routes = [
    { path: '/login', component: LoginForm }
]

export const router = createRouter({
    history: createWebHashHistory(),
    routes
})