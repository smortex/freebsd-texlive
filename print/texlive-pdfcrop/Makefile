# $FreeBSD$

PORTNAME=	pdfcrop
PORTVERSION=	20150413
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Crop PDF graphics.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
