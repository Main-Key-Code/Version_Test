# Version_Test

Major: Assemblies with the same name but different major versions are not interchangeable. 
       A higher version number might indicate a major rewrite of a product where backward compatibility cannot be assumed.
       
Minor: If the name and major version number on two assemblies are the same, but the minor version number is different, this indicates
       significant enhancement with the intention of backward compatibility.
       This higher minor version number might indicate a point release of a product or a fully backward-compatible new version of a product.

Build: A difference in build number represents a recompilation of the same source. 
       Different build numbers might be used when the processor, platform, or compiler changes.

Revision: Assemblies with the same name, major, and minor version numbers but different revisions are intended to be fully interchangeable. 
          A higher revision number might be used in a build that fixes a security hole in a previously released assembly.
          
확장자 csproj 에 추가 작업
.<AssemblyVersion>22.07.*</AssemblyVersion>
.<Deterministic>false</Deterministic>

![image](https://user-images.githubusercontent.com/72923266/179133588-763aecc2-bb96-4c30-8f34-05675b4661ac.png)

    
    
