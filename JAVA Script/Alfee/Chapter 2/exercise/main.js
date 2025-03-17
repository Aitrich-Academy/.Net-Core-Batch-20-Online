var jobsList = [
  {
    jobIcon: "./images/Company Logo (2).png",
    jobTitle: "Social Media Assistant",
    Location: "online",
    date:"16-06-2023",
    Time: "10 A M"
  },
  {
    jobIcon: "./images/Logo 27.png",
    jobTitle: "Brand Designer",
    Location: "offline",
    date:"19-06-2023",
    Time: "12 A M"
  },
  {
    jobIcon: "./images/Logo.png",
    jobTitle: "Custom Manager",
    Location: "online",
    date:"20-06-2023",
    Time: "12 A M"
  },
];

function loadData() {
  var container = document.getElementById("content_container");
  container.innerHTML = "";

  jobsList.forEach((element) => {
    var jobDiv = document.createElement("div");
    jobDiv.style.display = "flex";
    jobDiv.style.alignItems = "center";
    jobDiv.style.marginBottom = "10px";

  
    var img = document.createElement("img");
    img.src = element.jobIcon;
    img.width = 50;
    img.height = 50;
    img.style.marginRight = "10px";

    var jobInfo = document.createElement("div");

    var jobTitle = document.createElement("h4");
    jobTitle.innerText = element.jobTitle;
    jobTitle.style.margin=0

    var location = document.createElement("p");
    location.innerText = `Location: ${element.Location}`;
    location.style.margin=0

    var date =document.createElement("p");
    date.innerText = `date: ${element.date}`;
    date.style.margin=0

    var Time =document.createElement("p");
    Time.innerText = `Time: ${element.Time}`;
    Time.style.margin=0


    jobInfo.appendChild(jobTitle);
    jobInfo.appendChild(location);
    jobInfo.appendChild(date);
    jobInfo.appendChild(Time);

    jobDiv.appendChild(img);
    jobDiv.appendChild(jobInfo);

    container.appendChild(jobDiv);
  });
}
