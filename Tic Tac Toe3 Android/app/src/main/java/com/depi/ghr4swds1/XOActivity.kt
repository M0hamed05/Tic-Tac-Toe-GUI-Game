package com.depi.ghr4swds1

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.constraintlayout.widget.ConstraintSet.INVISIBLE
import androidx.constraintlayout.widget.ConstraintSet.VISIBLE


class XOActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_xoactivity)
        val Btn1 = findViewById<Button>(R.id.Btn1)
        val Btn2 = findViewById<Button>(R.id.Btn2)
        val Btn3 = findViewById<Button>(R.id.Btn3)
        val Btn4 = findViewById<Button>(R.id.Btn4)
        val Btn5 = findViewById<Button>(R.id.Btn5)
        val Btn6 = findViewById<Button>(R.id.Btn6)
        val Btn7 = findViewById<Button>(R.id.Btn7)
        val Btn8 = findViewById<Button>(R.id.Btn8)
        val Btn9 = findViewById<Button>(R.id.Btn9)
        val Buttons = listOf<Button>(Btn1,Btn2,Btn3,Btn4,Btn5,Btn6,Btn7,Btn8,Btn9)

        val PlayAgainBtn = findViewById<Button>(R.id.playAgainBtn)
        val GobackBtn = findViewById<Button>(R.id.GoBackBtn)

        val turn = findViewById<TextView>(R.id.turn)
        val winner = findViewById<TextView>(R.id.winner)

        var resultApplied = false
        var player1 = true;
        var timesPlayed = 0

        fun applyBtnClick(Btn:Button) {
            if (!resultApplied) {
                if (Btn.text != "X" && Btn.text != "O") {
                    if (player1) {
                        Btn.text = "X"
                        turn.text = "2"
                        player1 = false
                        timesPlayed++
                    } else {
                        turn.text = "1"
                        Btn.text = "O"
                        player1 = true
                        timesPlayed++
                    }
                }
            }
        }

        fun checkWinner() : String{
            if(Btn1.text == Btn2.text && Btn2.text == Btn3.text) return Btn1.text.toString();
            if(Btn4.text == Btn5.text && Btn5.text == Btn6.text) return Btn4.text.toString();
            if(Btn7.text == Btn8.text && Btn8.text == Btn9.text) return Btn8.text.toString();

            if(Btn1.text == Btn4.text && Btn4.text == Btn7.text) return Btn1.text.toString();
            if(Btn2.text == Btn5.text && Btn5.text == Btn8.text) return Btn2.text.toString();
            if(Btn3.text == Btn6.text && Btn6.text == Btn9.text) return Btn3.text.toString();

            if(Btn1.text == Btn5.text && Btn5.text == Btn9.text) return Btn1.text.toString();
            if(Btn3.text == Btn5.text && Btn5.text == Btn7.text) return Btn3.text.toString();
            return ""
        }

        fun applyResult() {
            if (!resultApplied) {
                if (checkWinner() == "X") {
                    resultApplied = true
                    winner.text = "Player1"
                    turn.visibility = INVISIBLE
                    PlayAgainBtn.visibility = VISIBLE
                } else if (checkWinner() == "O") {
                    resultApplied = true
                    winner.text = "Player2"
                    turn.visibility = INVISIBLE
                    PlayAgainBtn.visibility = VISIBLE
                } else {
                    if (timesPlayed == 9) {
                        winner.text = "Draw"
                        PlayAgainBtn.visibility = VISIBLE
                    } else {
                        winner.text = "None"
                    }
                }
            }
        }

        for(btn in Buttons){
            btn.setOnClickListener {
                applyBtnClick(btn)
                applyResult()
            }
        }

        fun refersh_all(){
            for(btn in Buttons){
                    btn.text = ""
            }
            timesPlayed = 0
            resultApplied = false

            turn.visibility = VISIBLE
            winner.text = "None"
            PlayAgainBtn.visibility = INVISIBLE
        }

        PlayAgainBtn.setOnClickListener {
            refersh_all()
        }

        GobackBtn.setOnClickListener {
            finish()
        }

    }
}
