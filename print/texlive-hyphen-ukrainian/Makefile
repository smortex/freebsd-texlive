# New ports collection makefile for:	texlive-hyphen-ukrainian
# Date created:		13/03/2010 04:35:09
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	hyphen-ukrainian
PORTVERSION=	20101020
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The hyphen-ukrainian package

RUN_DEPENDS=	${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/ukrhyph/ukrhyph.tex:${PORTSDIR}/print/texlive-ukrhyph

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
