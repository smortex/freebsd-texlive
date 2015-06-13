# $FreeBSD$

PORTNAME=	pygmentex
PORTVERSION=	20150413
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Use Pygments to format code listings in documents.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
