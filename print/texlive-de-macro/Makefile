# $FreeBSD$

PORTNAME=	de-macro
PORTVERSION=	20150412
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Expand private macros in a document.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
