package com.depi.ghr4swds1

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.constraintlayout.widget.ConstraintSet.INVISIBLE
import androidx.constraintlayout.widget.ConstraintSet.VISIBLE
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.transition.Visibility

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        val NextBtn = findViewById<Button>(R.id.nextBtn)
        val NextBtn2 = findViewById<Button>(R.id.nextBtn2)
        NextBtn.setOnClickListener {
            var nextActivity = Intent(this, XOActivity::class.java)
            startActivity(nextActivity)
        }
        NextBtn2.setOnClickListener {
            var nextActivity2 = Intent(this, JustActivity::class.java)
            startActivity(nextActivity2)
            finish() //needs to be here so he can't come back to login
        }

    }
}










        /*
        var pressed = true
        val Btn1  = findViewById<Button>(R.id.btnButton1)
        val txt1 = findViewById<TextView>(R.id.txtView)

            Btn1.setOnClickListener {
                if(!pressed) {
                    Btn1.text = "Clicked"
                    txt1.visibility = VISIBLE
                    pressed = true
                }else{
                    Btn1.text = "Btn"
                    txt1.visibility = INVISIBLE
                    pressed = false
                }
            }
        val sumBtn  = findViewById<Button>(R.id.sum)
        val minceBtn  = findViewById<Button>(R.id.mince)
        val divideBtn  = findViewById<Button>(R.id.divide)
        val multiBtn  = findViewById<Button>(R.id.multiply)
        val num1 = findViewById<EditText>(R.id.num1)
        val num2 = findViewById<EditText>(R.id.num2)
        val result = findViewById<TextView>(R.id.result)

        sumBtn.setOnClickListener {
            if (num1.text.toString() == "" || num2.text.toString() == "")
                result.text = "Requried Feild is empty"
            else
                result.text = "${num1.text.toString().toInt() + num2.text.toString().toInt()}"
        }
        minceBtn.setOnClickListener {
            if (num1.text.toString() == "" || num2.text.toString() == "")
                result.text = "Requried Feild is empty"
            else
            result.text = "${num1.text.toString().toInt()-num2.text.toString().toInt()}"
        }
        divideBtn.setOnClickListener {
            if (num1.text.toString() == "" || num2.text.toString() == "")
                result.text = "Requried Feild is empty"
            else if(num2.text.toString().toInt() == 0)
                result.text = "number 2 can't be 0, math error"
            else
            result.text = "${num1.text.toString().toInt()/num2.text.toString().toInt()}"
        }
        multiBtn.setOnClickListener {
            if (num1.text.toString() == "" || num2.text.toString() == "")
                result.text = "Requried Feild is empty"
            else
            result.text = "${num1.text.toString().toInt()*num2.text.toString().toInt()}"
        }
        */