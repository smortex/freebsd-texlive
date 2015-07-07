# $FreeBSD$

PORTNAME=	mptopdf
PORTVERSION=	20150706
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	mpost to PDF, native MetaPost graphics inclusion

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
