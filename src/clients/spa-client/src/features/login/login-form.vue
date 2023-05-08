<script setup>
import { ref } from "vue";
import { AuthService } from '@/services/auth'

const email = ref('');
const password = ref('');

const authService = new AuthService();

function onSubmit(e){
    //todo implement login api
    authService.login(email.value, password.value);
}

</script>

<template>
    <div class="form-wrapper">
        <form @submit.prevent="onSubmit">            
            <div class="input-container"> 
                <label class="input-label">Email</label> 
                <input type="email" v-model="email"/> 
            </div>            
            <div class="input-container"> 
                <label class="input-label">Password</label> 
                <input type="password" v-model="password"/> 
            </div>
            <input type="submit" @submit.prevent="onSubmit" value="Войти"/>
        </form>
    </div>
</template>

<style scoped>
.form-wrapper form{
    display: flex;
    width: 250px;
    padding: 10px;
    flex-direction: column;
    gap: 15px;
}
.input-container{
    display: flex;
    width: 100%;
    flex-direction: column;
}
.input-container label{
    font-size: 0.8rem;
}
.input-container input, input[type='submit']{
    padding: 4px;
    border: none
}
.input-container input{
    border-bottom: 1px solid;
}
</style>