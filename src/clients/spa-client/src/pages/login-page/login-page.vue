<script setup lang="ts">

import LoginForm from '@/components/b-login-form'

function onLogedin() {
    window.location.replace('/')
}

</script>

<template>
    <div class="page-wrapper">
        <div class="page-container">
            <div class="product-identity">
                <div class="placeholder">
                    Placeholder
                </div>

            </div>
            <div class="login-form-container">
                <login-form @logedin="onLogedin" />
            </div>
        </div>
    </div>
</template>

<style scoped>
.page-wrapper {
    width: 100%;
    background-color: #cecece;
}

.page-container {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    width: 100%;

}

.product-identity {
    height: 100vh;
    width: 100%;
    display: flex;
    align-items: center;
    justify-content: center;

}

.login-form-container {
    display: flex;
    height: 100vh;
    background-color: #ffffff;
    padding: 5px;
    width: 50vw;
    max-width: 700px;
}

.placeholder {
    font-size: 3rem;
    color: rgb(156, 156, 156);
}
</style>