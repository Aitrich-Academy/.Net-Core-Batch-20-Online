
function activatenotnull()
    {
        let email=document.myform.email.value;
        let pwd=document.myform.pwd.value;
        console.log(email)
        if(email==""||email==null)
        {
           let err=document.createElement("p")
           err.innerHTML=`<span>please enter</span>`;
            document.myform.email.appendChild(err);
           
        }
        else if(pwd==""||pwd==null)
        {
            alert("please enter your Password");
        }
        else if(email=="radhikrishna@gmail.com"&&pwd=="12345")
        {
            alert("email And Password are correct")
        }
        else
        {
            alert("Please enter valid email or password")
        }

    

    }



