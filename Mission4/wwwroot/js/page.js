
// This function is the grade score calculator. It calculates by grade weights and also tells them their letter grade

$("#button").click(function () {
    let assignments = parseInt($("#assignments").val()) * .5;
    let quizzes = parseInt($("#quizzes").val()) * .1;
    let g_p = parseInt($("#group_projects").val()) * .1;
    let intex = parseInt($("#intex").val()) * .1;
    let m_e = parseInt($("#midterm_exam").val()) * .1;
    let f_e = parseInt($("#final_exam").val()) * .1;

    let num_grade = (assignments + quizzes + g_p + intex + m_e + f_e).toFixed(1);
 
    /* alert("Your total score is " + output + "%!");*/

    let output = ""

    if (num_grade >= 94) {
        output = "A"
    }
    else if (num_grade >= 90) {
        output = "A-"
    }
    else if (num_grade >= 87) {
        output = "B+"
    }
    else if (num_grade >= 84) {
        output = "B"
    }
    else if (num_grade >= 80) {
        output = "B-"
    }
    else if (num_grade >= 77) {
        output = "C+"
    }
    else if (num_grade >= 74) {
        output = "C"
    }
    else if (num_grade >= 70) {
        output = "C-"
    }
    else if (num_grade >= 67) {
        output = "D+"
    }
    else if (num_grade >= 64) {
        output = "D"
    }
    else if (num_grade >= 60) {
        output = "D-"
    }
    else {
        output = "E. You oughta get it together man"
    }

    alert('You got a ' + output + ". That's a " + num_grade + "%!");

   /* $("#score").html('You got a ' + output + ". That's a " + num_grade + "%!")*/

});



