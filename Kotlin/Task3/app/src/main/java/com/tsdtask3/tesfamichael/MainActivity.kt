package com.tsdtask3.tesfamichael

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.content.Context
import android.os.Handler
import android.os.Looper
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import okhttp3.*
import java.io.IOException

class MainActivity : AppCompatActivity() {
    lateinit var button: Button
    lateinit var user_input: EditText
    lateinit var mul: EditText
    var url: String = ""

    val client = OkHttpClient()
    val baseUrl = "http://10.0.2.2:8080/mult"
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        button = findViewById(R.id.button)
        user_input = findViewById(R.id.user_input)
        mul = findViewById(R.id.mul)

        button.setOnClickListener {
            url = baseUrl + "?mul=${mul.text}&input=${user_input.text}"
            sendRequest(url)
        }
}


    fun sendRequest(url_r: String) {
        Toast.makeText(
            this,
            "Sending request of ",
            Toast.LENGTH_SHORT
        ).show()
        val request = Request.Builder()
            .url(url_r)
            .build()

        client.newCall(request).enqueue(object : Callback {
            override fun onFailure(call: Call, e: IOException) {
                println("========== Error ===================")
                println(e.message)
                println("===================================")

            }
            override fun onResponse(call: Call, response: Response) = viewToast(response.body?.string())
        })
    }

    fun viewToast(text: String?) {
        if (text != null) {
            Handler(Looper.getMainLooper()).post(Runnable {
                Toast.makeText(
                    this,
                    "Result: $text",
                    Toast.LENGTH_SHORT
                ).show()
            })
        }
    }

}