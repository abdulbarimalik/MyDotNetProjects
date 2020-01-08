window.onload = loadAnimatedFlag;
function loadAnimatedFlag() {
    var allDivs = document.getElementsByTagName('div');

    if (document.getElementById('flagdomLink') != null) {
        var flagdomLink = document.getElementById('flagdomLink');
        var linkhref = flagdomLink.getAttribute('href');
        var anchor = flagdomLink.innerHTML;
        flagdomLink.style.visibility = 'visible';
        flagdomLink.style.opacity = '1';


        for (var i = 0; i < allDivs.length; i++) {
            var className = allDivs[i].getAttribute('class');
            if (className == "animatedFlagFlagdom") {
                if (linkhref == "http://www.flagdom.com" && (anchor == "Flagdom" || anchor == "Flags" || anchor == "Flag" || anchor == "American Flag" || anchor == "American Flags")) {
                    var flagName = allDivs[i].getAttribute('title');
                    var animatedFlagScript = '<object width="100%" height="100%" type="video/x-shockwave-flash"><param name="movie" value="http://www.flagdom.com/flag-resources/wavingflag.swf" /><param name="quality" value="high" /> <param name="wmode" value="transparent" /> <param name="scale" value="exactfit"><param name=FlashVars value="image_var=http://www.flagdom.com/flag-resources/image.php?image=' + flagName + '" /><embed src="http://www.flagdom.com/flag-resources/wavingflag.swf" FlashVars="image_var=http://www.flagdom.com/flag-resources/image.php?image=' + flagName + '" scale="exactfit" wmode="transparent" quality="high" width="100%" height="100%" name="wavingflag" type="application/x-shockwave-flash"></embed> </object>';
                    allDivs[i].innerHTML = animatedFlagScript;
                }
                else {
                    badLink(allDivs[i]);
                }
            }
        }
    }
    else {
        for (var i = 0; i < allDivs.length; i++) {
            var className = allDivs[i].getAttribute('class');
            if (className == "animatedFlagFlagdom") {
                badLink(allDivs[i]);
            }
        }
    }
}

function badLink(div) {
    div.style.fontFamily = "arial";
    div.style.fontSize = "13px";
    div.style.width = "500px";
    div.style.height = "100px";
    div.style.display = "block";
    div.style.position = "absolute";
    div.style.top = "5px;";
    div.style.left = "5px";
    div.style.lineHeight = "20px";
    div.style.backgroundColor = "yellow";
    div.style.padding = "5px";
    div.style.border = "1px solid black";
    div.style.color = "black";
    div.innerHTML = '<b>Animated Flag Error:</b><br />In order to display our animated flag on your site for free, you must include the following link somewhere on this page:<br /><b>&#60a href="http://www.flagdom.com" id="flagdomLink"&#62Flagdom&#60/a&#62</b><br />If you have any questions, please contact us at info@flagdom.com';
    div.parentNode.removeChild(div);
    document.body.appendChild(div);
}