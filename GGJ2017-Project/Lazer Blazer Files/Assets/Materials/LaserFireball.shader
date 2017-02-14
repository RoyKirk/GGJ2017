// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:33561,y:33073,varname:node_4013,prsc:2|emission-3222-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:2966,x:32607,y:33125,ptovrint:False,ptlb:Burn Texture,ptin:_BurnTexture,varname:node_2966,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:271f5ee3273dd7f4fae6e204d4f8c4bf,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1498,x:32837,y:33014,varname:node_1498,prsc:2,tex:271f5ee3273dd7f4fae6e204d4f8c4bf,ntxv:0,isnm:False|UVIN-7469-OUT,TEX-2966-TEX;n:type:ShaderForge.SFN_Append,id:7469,x:32607,y:32897,varname:node_7469,prsc:2|A-521-OUT,B-2064-OUT;n:type:ShaderForge.SFN_Vector1,id:2064,x:32428,y:32976,varname:node_2064,prsc:2,v1:0;n:type:ShaderForge.SFN_Tex2d,id:3863,x:31358,y:33092,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_3863,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Add,id:1638,x:31672,y:32897,varname:node_1638,prsc:2|A-9398-OUT,B-3863-R;n:type:ShaderForge.SFN_RemapRange,id:9398,x:31482,y:32897,varname:node_9398,prsc:2,frmn:0,frmx:1,tomn:-0.8,tomx:0.8|IN-5996-OUT;n:type:ShaderForge.SFN_OneMinus,id:5996,x:31324,y:32897,varname:node_5996,prsc:2|IN-1086-OUT;n:type:ShaderForge.SFN_RemapRange,id:7214,x:31846,y:32897,varname:node_7214,prsc:2,frmn:0,frmx:1,tomn:-4,tomx:4|IN-1638-OUT;n:type:ShaderForge.SFN_Clamp01,id:536,x:32017,y:32897,varname:node_536,prsc:2|IN-7214-OUT;n:type:ShaderForge.SFN_OneMinus,id:2236,x:32212,y:32897,varname:node_2236,prsc:2|IN-536-OUT;n:type:ShaderForge.SFN_TexCoord,id:9945,x:31002,y:32370,varname:node_9945,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:7734,x:31229,y:32510,varname:node_7734,prsc:2|A-9945-UVOUT,B-5041-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6285,x:31435,y:32510,varname:node_6285,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-7734-OUT;n:type:ShaderForge.SFN_Frac,id:8026,x:31626,y:32510,varname:node_8026,prsc:2|IN-6285-OUT;n:type:ShaderForge.SFN_Time,id:7045,x:30410,y:32827,varname:node_7045,prsc:2;n:type:ShaderForge.SFN_RemapRange,id:1086,x:30995,y:32827,varname:node_1086,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-1279-OUT;n:type:ShaderForge.SFN_Multiply,id:6992,x:30640,y:32827,varname:node_6992,prsc:2|A-4773-OUT,B-7045-T,C-7152-OUT;n:type:ShaderForge.SFN_Sin,id:1279,x:30814,y:32827,varname:node_1279,prsc:2|IN-6992-OUT;n:type:ShaderForge.SFN_RemapRange,id:1585,x:30995,y:33013,varname:node_1585,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-6471-OUT;n:type:ShaderForge.SFN_Multiply,id:8926,x:30640,y:33013,varname:node_8926,prsc:2|A-7045-T,B-4773-OUT,C-7152-OUT;n:type:ShaderForge.SFN_Append,id:7095,x:32552,y:33361,varname:node_7095,prsc:2|A-3503-OUT,B-6444-OUT;n:type:ShaderForge.SFN_Vector1,id:6444,x:32381,y:33395,varname:node_6444,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:8835,x:31617,y:33361,varname:node_8835,prsc:2|A-17-OUT,B-3863-R;n:type:ShaderForge.SFN_RemapRange,id:17,x:31427,y:33361,varname:node_17,prsc:2,frmn:0,frmx:1,tomn:-0.8,tomx:0.8|IN-5589-OUT;n:type:ShaderForge.SFN_OneMinus,id:5589,x:31269,y:33361,varname:node_5589,prsc:2|IN-1585-OUT;n:type:ShaderForge.SFN_RemapRange,id:8397,x:31791,y:33361,varname:node_8397,prsc:2,frmn:0,frmx:1,tomn:-4,tomx:4|IN-8835-OUT;n:type:ShaderForge.SFN_Clamp01,id:6963,x:31954,y:33361,varname:node_6963,prsc:2|IN-8397-OUT;n:type:ShaderForge.SFN_Add,id:3222,x:33053,y:33121,varname:node_3222,prsc:2|A-1498-RGB,B-5373-RGB,C-5501-OUT;n:type:ShaderForge.SFN_Tex2d,id:5373,x:32837,y:33212,varname:node_5373,prsc:2,tex:271f5ee3273dd7f4fae6e204d4f8c4bf,ntxv:0,isnm:False|UVIN-7095-OUT,TEX-2966-TEX;n:type:ShaderForge.SFN_Subtract,id:8293,x:31837,y:32538,varname:node_8293,prsc:2|A-8026-OUT,B-9753-OUT;n:type:ShaderForge.SFN_Vector1,id:9753,x:31626,y:32653,varname:node_9753,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Abs,id:1027,x:32017,y:32564,varname:node_1027,prsc:2|IN-8293-OUT;n:type:ShaderForge.SFN_Color,id:7899,x:32017,y:32711,ptovrint:False,ptlb:Glow Colour,ptin:_GlowColour,varname:node_7899,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.5586207,c3:0,c4:1;n:type:ShaderForge.SFN_RemapRange,id:5041,x:31002,y:32510,varname:node_5041,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-74-OUT;n:type:ShaderForge.SFN_RemapRange,id:521,x:32406,y:32808,varname:node_521,prsc:2,frmn:-1,frmx:0,tomn:-0.5,tomx:0|IN-2236-OUT;n:type:ShaderForge.SFN_RemapRange,id:3503,x:32264,y:33343,varname:node_3503,prsc:2,frmn:0,frmx:1,tomn:0,tomx:0.5|IN-6963-OUT;n:type:ShaderForge.SFN_Sin,id:74,x:30785,y:32527,varname:node_74,prsc:2|IN-7045-T;n:type:ShaderForge.SFN_Cos,id:6471,x:30829,y:33013,varname:node_6471,prsc:2|IN-8926-OUT;n:type:ShaderForge.SFN_Tau,id:4773,x:30410,y:33013,varname:node_4773,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:7152,x:30410,y:33167,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_7152,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Add,id:5501,x:32226,y:32675,varname:node_5501,prsc:2|A-1027-OUT,B-7899-RGB;proporder:2966-3863-7899-7152;pass:END;sub:END;*/

Shader "Shader Forge/Practice7" {
    Properties {
        _BurnTexture ("Burn Texture", 2D) = "white" {}
        _Noise ("Noise", 2D) = "white" {}
        _GlowColour ("Glow Colour", Color) = (1,0.5586207,0,1)
        _Speed ("Speed", Float ) = 0.2
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _BurnTexture; uniform float4 _BurnTexture_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float4 _GlowColour;
            uniform float _Speed;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float node_4773 = 6.28318530718;
                float4 node_7045 = _Time + _TimeEditor;
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float2 node_7469 = float2(((1.0 - saturate(((((1.0 - (sin((node_4773*node_7045.g*_Speed))*0.5+0.5))*1.6+-0.8)+_Noise_var.r)*8.0+-4.0)))*0.5+0.0),0.0);
                float4 node_1498 = tex2D(_BurnTexture,TRANSFORM_TEX(node_7469, _BurnTexture));
                float2 node_7095 = float2((saturate(((((1.0 - (cos((node_7045.g*node_4773*_Speed))*0.5+0.5))*1.6+-0.8)+_Noise_var.r)*8.0+-4.0))*0.5+0.0),0.0);
                float4 node_5373 = tex2D(_BurnTexture,TRANSFORM_TEX(node_7095, _BurnTexture));
                float node_1027 = abs((frac((i.uv0+(sin(node_7045.g)*0.5+0.5)).g)-0.5));
                float3 node_3222 = (node_1498.rgb+node_5373.rgb+(node_1027+_GlowColour.rgb));
                float3 emissive = node_3222;
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
