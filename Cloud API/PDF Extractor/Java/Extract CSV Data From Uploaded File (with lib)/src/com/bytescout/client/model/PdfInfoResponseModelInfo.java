/*
 * bytescout.io
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2017-05-11T04:47:23Z
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bytescout.client.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * PDF document information
 */
@ApiModel(description = "PDF document information")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-05-11T14:49:35.132Z")
public class PdfInfoResponseModelInfo {
  @SerializedName("PageCount")
  private Integer pageCount = null;

  @SerializedName("Author")
  private String author = null;

  @SerializedName("Title")
  private String title = null;

  @SerializedName("Producer")
  private String producer = null;

  @SerializedName("Subject")
  private String subject = null;

  @SerializedName("CreationDate")
  private String creationDate = null;

  @SerializedName("Bookmarks")
  private String bookmarks = null;

  @SerializedName("Keywords")
  private String keywords = null;

  @SerializedName("Creator")
  private String creator = null;

  @SerializedName("EmbeddedFileCount")
  private Integer embeddedFileCount = null;

  @SerializedName("Encrypted")
  private Boolean encrypted = null;

  public PdfInfoResponseModelInfo pageCount(Integer pageCount) {
    this.pageCount = pageCount;
    return this;
  }

   /**
   * Count of pages
   * @return pageCount
  **/
  @ApiModelProperty(example = "null", value = "Count of pages")
  public Integer getPageCount() {
    return pageCount;
  }

  public void setPageCount(Integer pageCount) {
    this.pageCount = pageCount;
  }

  public PdfInfoResponseModelInfo author(String author) {
    this.author = author;
    return this;
  }

   /**
   * Document author
   * @return author
  **/
  @ApiModelProperty(example = "null", value = "Document author")
  public String getAuthor() {
    return author;
  }

  public void setAuthor(String author) {
    this.author = author;
  }

  public PdfInfoResponseModelInfo title(String title) {
    this.title = title;
    return this;
  }

   /**
   * Document title
   * @return title
  **/
  @ApiModelProperty(example = "null", value = "Document title")
  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public PdfInfoResponseModelInfo producer(String producer) {
    this.producer = producer;
    return this;
  }

   /**
   * Document producer
   * @return producer
  **/
  @ApiModelProperty(example = "null", value = "Document producer")
  public String getProducer() {
    return producer;
  }

  public void setProducer(String producer) {
    this.producer = producer;
  }

  public PdfInfoResponseModelInfo subject(String subject) {
    this.subject = subject;
    return this;
  }

   /**
   * Document subject
   * @return subject
  **/
  @ApiModelProperty(example = "null", value = "Document subject")
  public String getSubject() {
    return subject;
  }

  public void setSubject(String subject) {
    this.subject = subject;
  }

  public PdfInfoResponseModelInfo creationDate(String creationDate) {
    this.creationDate = creationDate;
    return this;
  }

   /**
   * Document creation date
   * @return creationDate
  **/
  @ApiModelProperty(example = "null", value = "Document creation date")
  public String getCreationDate() {
    return creationDate;
  }

  public void setCreationDate(String creationDate) {
    this.creationDate = creationDate;
  }

  public PdfInfoResponseModelInfo bookmarks(String bookmarks) {
    this.bookmarks = bookmarks;
    return this;
  }

   /**
   * Document bookmarks
   * @return bookmarks
  **/
  @ApiModelProperty(example = "null", value = "Document bookmarks")
  public String getBookmarks() {
    return bookmarks;
  }

  public void setBookmarks(String bookmarks) {
    this.bookmarks = bookmarks;
  }

  public PdfInfoResponseModelInfo keywords(String keywords) {
    this.keywords = keywords;
    return this;
  }

   /**
   * Document keywords
   * @return keywords
  **/
  @ApiModelProperty(example = "null", value = "Document keywords")
  public String getKeywords() {
    return keywords;
  }

  public void setKeywords(String keywords) {
    this.keywords = keywords;
  }

  public PdfInfoResponseModelInfo creator(String creator) {
    this.creator = creator;
    return this;
  }

   /**
   * Document creator
   * @return creator
  **/
  @ApiModelProperty(example = "null", value = "Document creator")
  public String getCreator() {
    return creator;
  }

  public void setCreator(String creator) {
    this.creator = creator;
  }

  public PdfInfoResponseModelInfo embeddedFileCount(Integer embeddedFileCount) {
    this.embeddedFileCount = embeddedFileCount;
    return this;
  }

   /**
   * Count of embedded files
   * @return embeddedFileCount
  **/
  @ApiModelProperty(example = "null", value = "Count of embedded files")
  public Integer getEmbeddedFileCount() {
    return embeddedFileCount;
  }

  public void setEmbeddedFileCount(Integer embeddedFileCount) {
    this.embeddedFileCount = embeddedFileCount;
  }

  public PdfInfoResponseModelInfo encrypted(Boolean encrypted) {
    this.encrypted = encrypted;
    return this;
  }

   /**
   * Document encryption status
   * @return encrypted
  **/
  @ApiModelProperty(example = "null", value = "Document encryption status")
  public Boolean getEncrypted() {
    return encrypted;
  }

  public void setEncrypted(Boolean encrypted) {
    this.encrypted = encrypted;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PdfInfoResponseModelInfo pdfInfoResponseModelInfo = (PdfInfoResponseModelInfo) o;
    return Objects.equals(this.pageCount, pdfInfoResponseModelInfo.pageCount) &&
        Objects.equals(this.author, pdfInfoResponseModelInfo.author) &&
        Objects.equals(this.title, pdfInfoResponseModelInfo.title) &&
        Objects.equals(this.producer, pdfInfoResponseModelInfo.producer) &&
        Objects.equals(this.subject, pdfInfoResponseModelInfo.subject) &&
        Objects.equals(this.creationDate, pdfInfoResponseModelInfo.creationDate) &&
        Objects.equals(this.bookmarks, pdfInfoResponseModelInfo.bookmarks) &&
        Objects.equals(this.keywords, pdfInfoResponseModelInfo.keywords) &&
        Objects.equals(this.creator, pdfInfoResponseModelInfo.creator) &&
        Objects.equals(this.embeddedFileCount, pdfInfoResponseModelInfo.embeddedFileCount) &&
        Objects.equals(this.encrypted, pdfInfoResponseModelInfo.encrypted);
  }

  @Override
  public int hashCode() {
    return Objects.hash(pageCount, author, title, producer, subject, creationDate, bookmarks, keywords, creator, embeddedFileCount, encrypted);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PdfInfoResponseModelInfo {\n");
    
    sb.append("    pageCount: ").append(toIndentedString(pageCount)).append("\n");
    sb.append("    author: ").append(toIndentedString(author)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    producer: ").append(toIndentedString(producer)).append("\n");
    sb.append("    subject: ").append(toIndentedString(subject)).append("\n");
    sb.append("    creationDate: ").append(toIndentedString(creationDate)).append("\n");
    sb.append("    bookmarks: ").append(toIndentedString(bookmarks)).append("\n");
    sb.append("    keywords: ").append(toIndentedString(keywords)).append("\n");
    sb.append("    creator: ").append(toIndentedString(creator)).append("\n");
    sb.append("    embeddedFileCount: ").append(toIndentedString(embeddedFileCount)).append("\n");
    sb.append("    encrypted: ").append(toIndentedString(encrypted)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

