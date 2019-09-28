
// $('.img-doc-MacOS, .macOS, .linux').css('display','none');

// Detecting os
var OSName="Unknown OS";

function user_os()
{
	if (navigator.appVersion.indexOf("Win")!=-1) OSName="Windows";
	if (navigator.appVersion.indexOf("Mac")!=-1) OSName="MacOS";
	if (navigator.appVersion.indexOf("X11")!=-1) OSName="UNIX";
	if (navigator.appVersion.indexOf("Linux")!=-1) OSName="Linux";

	// if (OSName == "Windows" || (OSName != "MacOS" && OSName != "Linux")) 
	// {
	// 	$('.img-doc-basic, .windows').css('display','block');
	// }

	if (OSName == "MacOS")
	{
		// displaying the right images for documentation 
		$('.img-doc-MacOS, .macos').css('display','block');
	}
	if (OSName == "Linux")
	{
		// displaying the right images for documentation 
		$('.img-doc-basic, .linux').css('display','block');
	}
	else if (OSName != "MacOS" && OSName != "Linux")
	{
		$('.img-doc-basic, .windows').css('display','block');
	}
	//document.write('Your OS: '+ OSName);
}
