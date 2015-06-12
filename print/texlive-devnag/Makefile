# $FreeBSD$

PORTNAME=	devnag
PORTVERSION=	20150412
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Typeset Devanagari.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
