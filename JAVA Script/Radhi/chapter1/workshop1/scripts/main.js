function validateForm()
{
    
    var jobTitle=document.myForm.jobTitle.value;  
    var description=document.myForm.jobDescription.value;  
    var salary=document.myForm.salary.value; 
    var location=document.myForm.location.value; 

    if(jobTitle==null || jobTitle=="")
    {
        alert(jobTitle+"Please enter your job title");
    
    }
     if(description==null || description=="")
    {
        alert("Please enter your job description");
        

    }
    if(salary==null || salary=="")
    {
        alert("Please enter your salary");
    

    }
    if(location==null ||location=="")
    {
        alert("Please enter your location");
    

    }
    

}

function validateCharacter(input)
{
   
    const regex = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(input.value))
    {
        alert("Allowed alphabets")
        input.value = input.value.replace(/[^A-Za-z]/g, '');
       
        return false;
    }

}


function validateSalary(salary) {
    return /^\d+(\.\d{1,2})?$/.test(salary);
}

function checkSalary() {
    const salaryInput = document.getElementById("salary").value;
    const result = document.getElementById("result");

    if (validateSalary(salaryInput)) {
        alert("Valid salary input.");
       
    } else {
        alert("Invalid salary. Please enter only numeric values.");
      
    }
}

