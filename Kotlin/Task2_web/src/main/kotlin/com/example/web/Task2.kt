package com.example.web

import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.PathVariable
import org.springframework.web.bind.annotation.RequestParam
import org.springframework.web.bind.annotation.RestController

@RestController
class Task2 {

    //    Main endpoint for the app
    @GetMapping("/mult")
    fun multiply(@RequestParam allParams: Map<String,String>): String {
        var mul: Int? = allParams?.get("mul")?.toInt();
        var input: String? = allParams?.get("input");
        var finalstring: String = "";

        if (mul != null && input != null) {
            finalstring = input.repeat(mul)
        }
        return "$finalstring ";
    }
}

