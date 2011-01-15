# New ports collection makefile for:	texlive-hyphen-ethiopic
# Date created:		01/15/2011 04:46:19
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	hyphen-ethiopic
PORTVERSION=	20110115
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The hyphen-ethiopic package

RUN_DEPENDS=	${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
