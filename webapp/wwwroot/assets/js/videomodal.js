function coursePreviewVideo() {
    const coursePreviewModal = document.querySelector(".js-course-preview-modal");
    if (coursePreviewModal) { /*if the element exists*/
        coursePreviewModal.addEventListener("shown.bs.modal", function () {
            this.querySelector(".js-course-preview-video").play();
            this.querySelector(".js-course-preview-video").currentTime = 0;
        });
        coursePreviewModal.addEventListener("hide.bs.modal", function(){
            this.querySelector(".js-course-preview-video").pause();
        });
    }
}

coursePreviewVideo()