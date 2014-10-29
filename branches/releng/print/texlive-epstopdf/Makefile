# $FreeBSD$

PORTNAME=	epstopdf
PORTVERSION=	20140620
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Convert EPS to 'encapsulated' PDF using Ghostscript.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
