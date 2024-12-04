﻿namespace Portfolio.Service.DTOs;
public class UserInfoDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Number { get; set; }
    public string UserDescription { get; set; }
    public byte[] ImageData { get; set; }  // Resim verisi (binary format)
    public string ImageMimeType { get; set; }  // Resmin türü (image/png, image/jpeg gibi)
    public string SvgData { get; set; }
}
