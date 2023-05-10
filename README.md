# AIEngine   

## 基于ChatGPT AI自动产生Shader  

  
使用方法：  
1，打开 Window/Package Manager  
2，选择 +/Add package from git URL...  
3，添加URL: https://github.com/ManoKing/AIEngine.git#1.0.8   


### AI Shader  

![GIF](https://user-images.githubusercontent.com/343936/223034386-cf69f2a2-d8ec-4537-9f1b-37051542b1cd.gif)

This is a proof-of-concept implementation of a ChatGPT-powered shader generator for Unity.

### How to try it

You have to generate an API key to use the ChatGPT API.
Please generate it on your [account page](https://platform.openai.com/account/api-keys)
and set it on the Project Settings page (Edit > Project Settings > AI Shader > API Key).

**CAUTION** - The API key is stored in `UserSettings/AIShaderSettings.asset`.
You must exclude the directory when sharing your project with others.

1, Use Assets/Create/AI Shader Create .aishader file.  
2, in Inspector of shader file, input Prompt. such as: Simple solid fill shader. The color is exposed as a property.  
3, Create some name Material.  
4, Click Generate.  
5, Clike Apply, Done.  


## 基于ChatGPT AI自动产生AICommand


![out](https://user-images.githubusercontent.com/343936/226172223-acfba006-8621-425f-a697-be745a94503f.gif)

This is a proof-of-concept integration of ChatGPT into Unity Editor. You can
control the Editor using natural language prompts.

### How to try it

You have to generate an API key to use the ChatGPT API. Please generate it on
your [account page](https://platform.openai.com/account/api-keys) and set it on
the Project Settings page (Edit > Project Settings > AI Command > API Key).

**CAUTION** - The API key is stored in `UserSettings/AICommandSettings.asset`.
You must exclude the directory when sharing your project with others.

You can open the AI Command window from Window > AI Command.

## 参考
1，AIShader https://github.com/keijiro/AIShader  
2，AICommon https://github.com/keijiro/AICommand  

修改API,降低Unity使用版本，支持Unity 2020.3.x  
将其制作成UPM，方便导入项目  