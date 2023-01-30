// grade calculator form function
$("#btnSend").click(function () {
    // get values from form
    assignments = $("#intex").val() * .5
    groupProject = $("#groupProject").val() * .1
    quizzes = $("#quizzes").val() * .1
    midtermExam = $("#midtermExam").val() * .1
    finalExam = $("#finalExam").val() * .1
    intex = $("#intex").val() * .1
    // calculate percentage grade
    percentageGrade = (assignments + groupProject + quizzes + midtermExam + finalExam + intex).toFixed(2)
    // calculate letter grade
    letterGrade = determineGrade(percentageGrade);
    // print to output
    string = "Your total percentage is " + Math.round(percentageGrade) + "% and your letter grade is a(n) "  + letterGrade;
    $("#results").text(string);
})


// determineGrade returns the letter grade based on a percent grade 
function determineGrade(total) {
    let letterGrade;
    if (total >= 94) {
        letterGrade = "A";
    } else if (total >= 90) {
        letterGrade = "A-";
    } else if (total >= 87) {
        letterGrade = "B+";
    } else if (total >= 84) {
        letterGrade = "B";
    } else if (total >= 80) {
        letterGrade = "B-";
    } else if (total >= 77) {
        letterGrade = "C+";
    } else if (total >= 74) {
        letterGrade = "C";
    } else if (total >= 70) {
        letterGrade = "D+";
    } else if (total >= 67) {
        letterGrade = "D";
    } else if (total >= 64) {
        letterGrade = "D-";
    } else {
        letterGrade = "E";
    }
    return letterGrade;
}
