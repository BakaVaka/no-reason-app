<script setup lang="ts">
import { ref } from 'vue';
import bInput from '@/components/b-input';

const username = ref<string>('')
const password = ref<string>('')

const emits = defineEmits(['logedin'])

function onSubmitForm() {
    emits('logedin')
}
</script>

<template>
    <div class="form-wrapper">
        <form class="form" @submit.prevent="onSubmitForm">
            <h2>
                Log in
            </h2>
            <b-input class="input-form-item" type="email" label="Email" v-model:value="username" />
            <b-input class="input-form-item" type="password" label="Password" v-model:value="password" />
            <br>
            <input type="submit" value="Log in">
        </form>
    </div>
</template>

<style scoped>
label {
    margin: 0;
    padding-left: 8px;
}

.form-wrapper {
    margin: auto;
    width: 400px;
}

.input-form-item {
    position: relative;
}

.form {
    display: flex;
    flex-direction: column;
    max-width: 300px;
    gap: 15px;
    padding: 10px;
    margin: auto;
}

input[type='submit'] {
    padding: 8px;
    border: none;
    width: inherit;
    border-radius: 7px;
    cursor: pointer;
}

</style>