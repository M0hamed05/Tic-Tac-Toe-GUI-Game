package com.depi.ghr4swds1

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class LoginActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_login)
        val BackBtn = findViewById<Button>(R.id.backBtn)
        BackBtn.setOnClickListener {
            var Intent = Intent(this, MainActivity::class.java)
            startActivity(Intent)
            finish()
        }
    }
}