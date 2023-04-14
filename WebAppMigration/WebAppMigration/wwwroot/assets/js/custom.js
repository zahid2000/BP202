
const loadMoreBtn = document.querySelector(".load-more")

loadMoreBtn.addEventListener("click", LoadMore)
//$(".load-more").click(LoadMore())
let dbServiceCount = document.querySelector("#serviceCount").value
//let dbServiceCount = $("#serviceCount").val()
function LoadMore() {
    let servicesCount = $(".services").children().length
    console.log(dbServiceCount)

    fetch("/Services/LoadMore?skip=" + servicesCount)
        .then(response => response.text())
        .then(text => {
            $(".services").append(text)
             servicesCount = $(".services").children().length
            if (servicesCount == dbServiceCount) {
                $(".load-more").remove()
            }
        })
   
   
  
    //console.log("Murad")
}