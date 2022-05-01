function likeContent(postId,likeButton) {
    alert('clicked')
    $(document).ready($.ajax({
        url: '/Home/Diary',
        type: 'POST',
        dataType:'text',
        data: {
            id: postId,
            likeId: postId
        },
        success: function (data) {
            $("." + likeButton).addClass('text-danger');
        },
        error: function (hata, ajaxOptions, thrownError) {
        }
    }))
}