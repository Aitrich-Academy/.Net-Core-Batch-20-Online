function validateForm()
{
    
    var jobTitle=document.myForm.jobTitle.value;  
    var description=document.myForm.jobDescription.value;  
    var salary=document.myForm.salary.value; 
    var location=document.myForm.location.value; 

    if(jobTitle==null || jobTitle=="")
    {
        alert(jobTitle+"Please enter your job title");
        return false;
    }
     if(description==null || description=="")
    {
        alert("Please enter your job description");
        return false;

    }
    if(salary==null || salary=="")
    {
        alert("Please enter your salary");
        return false;

    }
    if(location==null ||location=="")
    {
        alert("Please enter your location");
        return false;

    }
    

}

function validateCharacter(inputChar)
{
   
    const regex = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputChar))
    {
        alert("Allowed alphabets")
        return false;
    }

}
function validateDescription(inputDesc)
{
   
    const regex = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputDesc))
    {
        alert("Allowed alphabets")
        return false;
    }

}
function validateSalary(inputSalary)
{
   
    const regex = /^[0-9]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputSalary))
    {
        alert("Allowed numbers")
        return false;
    }

}
function validateLocation(inputLocation)
{
   
    const regex = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputLocation))
    {
        alert("Allowed alphabets")
        return false;
    }

}


