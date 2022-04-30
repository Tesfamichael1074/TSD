<!-- This example requires Tailwind CSS v2.0+ -->
<template>
  <Disclosure as="nav" class="bg-gray-800" >
    <div class="max-w-7xl mx-auto px-2 sm:px-6 lg:px-8">
      <div class="relative flex items-center justify-between h-16">
        <p class="text-white font-bold text-xl">Currency Exchange</p>
      </div>
    </div>
  </Disclosure>
</template>

<script>
import { Disclosure } from '@headlessui/vue'

export default {
  components: {
    Disclosure,
  },
  setup() {
    return {
    }
  },
}
</script>