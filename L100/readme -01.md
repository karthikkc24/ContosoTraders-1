# Intelligent Apps with Azure AI Services - L100

Lab time: 05 minutes

## Contoso Traders

Contoso Traders are one of the leading E-Commerce platforms with wide range of electronic products like Desktops and Laptops, Mobile Phones, Gaming console accessories and Monitors. 
This includes a wide range of international brands like Microsoft Surface, XBOX, Samsung, ASUS, DELL etc. Contoso Traders Organization is using Microsoft 365 for their collaboration works internally. 

Contoso Traders has different departments like Marketing, Sales, Accounts, HR, IT. For internal communication they are using Microsoft Teams and Outlook.
In Contoso Traders Organization, there are various functionalities with the Contoso Traders E-commerce platform like product approval, product price approval, Product price update approval etc.

December 2022

## Abstract and learning objectives

In this lab, you will explore the Contoso traders application [test.contosotraders.com](https://test.contosotraders.com/) and will go through the overview of app with focus on need for AI/Visual Search, use the image search option in the application to find the device from the product catalog and finally you will learn on the **Azure AI service** used in the application and also the high level idea of how the Cognitive services works.

For this we use the service called **Computer Vision**, an Azure AI that analyzes content in image and video.

Azure's Computer Vision service gives you access to advanced algorithms that process images and return information based on the visual features you're interested in such as **Optical Character Recognition** (OCR), Image Analysis, Face Service and Spatial Analysis.

## Requirements

- Microsoft Azure Subscription with required permissions.

## Instructions

1. Open browser and navigate to https://test.contosotraders.com/

   ![image](https://user-images.githubusercontent.com/48020356/204910981-44806350-9b7d-4b88-95f4-0c3c08196430.png)

   In the webpage you will be able to see the ecommerce store with clsuter of electronic products such as Laptops, Xbox controllers, Desktops, mobile phones amd monitors of different brands. 

2. Select the **Laptops** option from the list of Categories and observe the available laptops that can be purchased from the website in the product collection page and click on any product.

3. Then you be redirected to the specific product details page and here you can type the delivery pincode for checking the delivery availability, then you can add the number of quantity and also either you can add the product to the bag for checkout or the selected product can be pushed to wishlist.

3. Visit back to the **Homepage** for the special offers and recently added products, and also browse through the other product category for the newly launched and the available products.

4.  In the search bar of the application type **Laptop** and this will return with the list of Laptop available from the list of products available for purchase.

< Application should be updated to search the product with name >

5. Select the **SerachImage (1)** icon in the right of the serach bar and click on **Drag an image or upload a file (2)**.

   ![image](https://user-images.githubusercontent.com/48020356/204916409-3c559023-64e1-4c7a-95d5-558a5743dbde.png)
   
6. Either download an image from browser, and save it or select an locally existing image and click **Open**.
This will take you to the **Suggested Product list** page as per the image provided to search and you can select the prodcut you wish to buy from the application    from here.

   ![image](https://user-images.githubusercontent.com/48020356/204917533-db8beed3-29f5-4c34-9c4f-d35ffe8b906e.png)

   The **cloud-based Computer Vision API** provides developers with access to advanced algorithms for processing images and returning information. By uploading an   image or specifying an image URL, Microsoft Computer Vision algorithms can analyze visual content in different ways based on inputs and user choices.

   The **Image Analysis service** extracts many visual features from images, such as objects, faces, adult content, and auto-generated text descriptions, it provides  you with AI algorithms for processing images and returning information on their visual features. 

   We can use **Vision Studio** for understanding the process of Image Analysis in cognitive service using and Computer Vsion features

7. **Vision Studio** is a set of UI-based tools that lets you explore, build, and integrate features from Azure Computer Vision.

Vision Studio provides you with a platform to try several service features and sample their returned data in a quick, straightforward manner. Using Studio, you can start experimenting with the services and learning what they offer without needing to write any code. Then, use the available client libraries and REST APIs to get started embedding these services into your own applications.

8. Sign in to Vision Studio from https://portal.vision.cognitive.azure.com/ with your Azure subscription and if it's your first time logging in, you'll see a popup window appear that prompts you to **Sign in to Azure** and then choose or create a Vision resource. You have the option to skip this step and do it later also.
   
   ![image](https://user-images.githubusercontent.com/48020356/204954594-90143c0a-65c1-4155-9136-bb93ee57985a.png)
  
9. Select Choose resource, then select an existing resource within your subscription. If you'd like to create a new one, select Create a new resource. Then enter information for your new resource, such as a name, location, and resource group.
 
   ![image](https://user-images.githubusercontent.com/48020356/205177896-bcad5c19-ef01-47e5-96ed-099bf95e3f58.png)

10. Select **Create resource** and your resource will be created, and you'll be able to try Image Analysis offered by Vision Studio.

    ![image](https://user-images.githubusercontent.com/48020356/205178332-d2cab5a3-e553-4910-91fe-5058bceae12c.png)

11. Select the Analyze images tab, and select panel titled** Extract common tags** from images.

    ![image](https://user-images.githubusercontent.com/48020356/205179384-90e35cd6-f5bd-4c71-9c08-d54e0a2055f3.png)    

12. Select an image from the available set, or upload your own.

13. After you select your image, you'll see the detected tags appear in the output window along with their confidence scores. You can also select the JSON tab to see the JSON output that the API call returns.
