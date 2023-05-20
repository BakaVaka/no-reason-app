<script setup lang="ts">
import { defineProps, defineEmits } from 'vue';

type inputType = "text" | "email" | "password"

defineProps({
    label:String,
    value:String,
    type:
});
const emit = defineEmits(['update:value'])

function onValueChanged(e:Event){
    emit('update:value', e.target.value)
}

</script>

<template>
    <div class="input-wrapper">
        <label>{{ label }}</label>
        <input :value="value" @input="onValueChanged"/>
    </div>
</template>

<style scoped>
input{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
.input-wrapper{
    display: flex;
    flex-direction: column;
    align-items: baseline;
    width: 100%;
    position: relative;
}
label,input{ width: inherit; }

label{ 
    font-size: 0.8rem; 
    margin-left: 10px;
    color: #aaa;
}

input{ 
    padding: 4px;
}

</style>