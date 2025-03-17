

const mainarea=document.getElementById("contant");

// Create a table element
const table = document.createElement("table");
table.border = "1"; // Add border for visibility

// Get the main container
table.style.width = "50%";
table.style.borderCollapse = "collapse";

// Data to populate the table
var shortlist= [
    {image:"images/Userpic (2).png",name:"Alen",ql:"Qualification:MCA",ex:"Experience:3 year",loc:"Location:Banglore"},
    {image:"images/Userpic.png",name:"Vivek",ql:"Qualification:Btech",ex:"Experience:6 year",loc:"Location:Chennai"},
    {image:"images/Image.png",name:"Deepak Roy",ql:"Qualification:Btech",ex:"Experience:2 year",loc:"Location:Calicut"},
    {image:"images/img3.png",name:"Sarah",ql:"Qualification:MSc",ex:"Experience:2 year",loc:"Location:Kochi"}
];

// Loop through the data and create rows and cells
for (let i = 0; i < shortlist.length; i =i + 2) {
    const row = table.insertRow();
    
    for (let j = 0; j < 2; j++) {
        if (i + j < shortlist.length) {
            const cell = row.insertCell();
            cell.style.border = "1px solid black";
            cell.style.padding = "10px";
            
            const img = document.createElement("img");
            img.src = shortlist[i + j].image;
            img.style.width = "50px";
            img.style.height = "50px";
            img.style.display = "block";
            
            const textdiv = document.createElement("div");
            textdiv.innerHTML = `${shortlist[i + j].name}<br>${shortlist[i + j].ql}<br>${shortlist[i + j].ex}<br>${shortlist[i + j].loc}`;
            
            cell.appendChild(img);
            cell.appendChild(textdiv);
        }
    }
}

// Append the table to the body or any specific container
mainarea.appendChild(table);
