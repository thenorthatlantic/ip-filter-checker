# Ip Filter Checker
This is a simple Windows Forms application written in C# that checks if an IP address is blocked by an ISP.

## How it works

  The application uses the TcpClient class to connect to the specified IP address and port number. If the connection is successful, it means that the IP address is not blocked by the ISP. If the connection fails, it means that the IP address is blocked by the ISP. And timeout is useful to findout if IP address is limited.
  
## Requirments

.NET framework 4.6.2
  
  # نحوه استفاده 
1 -  به اینترنتی که می خواهید آیپی یا دامنه را در آن چک کنین متصل شوید.

2 - آدرس آیپی یا دامنه را در بخش IP وارد کنید.

3 - یک پورت باز در سرور را در بخش Port وارد کنید. (در سرور های لینوکس پورت 22 و در سرور های ویندوز پورت 3389 معمولا به طور پیشفرض باز هستند) 

4 - برای چک کردن آیپی معمولا 1000ms در قسمت timeout کافیست اما برای چک کردن دقیق تر دامین می توانید روی 10000ms تنظیم کنید.

5 -  دکمه Check را بزنید.

روی اینترنت ایرانسل میتونید چند بار Check رو بزنید اگه یه بار گفت وصل یه بار گفت قطع یکی اختلال رو آیپی هست.

..

** آپدیت: الان دیگه این ابزار خیلی کاربردی نیست **
