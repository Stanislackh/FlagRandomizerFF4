function swapBossImage(id, greyImage, colorImage) {
    console.log("blap");
    src = document.getElementById(id).src;
    if (src.match(greyImage)) {
        document.getElementById(id).src = colorImage;
    } else {
        document.getElementById(id).src = greyImage;
    }
}

function swapKeyItemImage(id, greyItem, colorItem, checkedItem) {
    console.log("Yuru Yuri");
    scr = document.getElementById(id).src;
    if (src.match(greyItem)) {
        document.getElementById(id).src = colorItem;
    }
    else if (src.match(colorItem)) {
        document.getElementById(id).src = checkedItem;
    }
    else {
        document.getElementById(id).src = greyItem;
    }
}

function swapCharacterImage(id, greyCharac, colorCharac, sadCharac) {
    console.log("Jahy-sama");
    scr = document.getElementById(id).src;
    if (src.match(greyCharac)) {
        document.getElementById(id).src = colorCharac;
    }
    else if (src.match(colorCharac)) {
        document.getElementById(id).src = sadCharac;
    }
    else {
        document.getElementById(id).src = greyCharac;
    }
}

function swapImg(link) {
    const imgs = link.querySelectorAll('img');
    let indexCurrent = null;
    let indexNewCurrent = null;
    imgs.forEach((img, index) => {
        if (img.classList.contains('current')) {
            indexCurrent = index;
            img.classList.remove('current');
        }
        if (indexCurrent === index - 1) {
            indexNewCurrent = index;
            img.classList.add('current');
        }
    });
    if (indexNewCurrent === null) {
        imgs[0].classList.add('current');
    }
}