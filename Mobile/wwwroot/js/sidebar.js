document.addEventListener("DOMContentLoaded", function() {
    const sidebar = document.querySelector(".sidebar");
    const toggleBtn = document.querySelector("#sidebar-toggle");
    const pageContainer = document.querySelector(".page-container");

    toggleBtn.addEventListener("click", () => {
        sidebar.classList.toggle("active");
    });

    pageContainer.addEventListener("click", (e) => {
        if (sidebar.classList.contains("active") && !sidebar.contains(e.target) && e.target !== toggleBtn) {
            sidebar.classList.remove("active");
        }
    });

    let touchStartX = 0;
    let touchEndX = 0;

    pageContainer.addEventListener("touchstart", (e) => {
        touchStartX = e.changedTouches[0].screenX;
    });

    pageContainer.addEventListener("touchend", (e) => {
        touchEndX = e.changedTouches[0].screenX;
        handleSwipe();
    });

    function handleSwipe() {
        if (touchEndX - touchStartX > 50) {
            sidebar.classList.add("active");
        } else if (touchStartX - touchEndX > 50) {
            sidebar.classList.remove("active");
        }
    }
});
